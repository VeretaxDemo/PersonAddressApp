using System;
using System.IO;
using System.Collections.Generic;

namespace DataManagementLibrary.DataAccess;

public class CsvDataAccess<T> where T: new ()
{
    public event EventHandler<T> BadEntryFound;

    // note the exercise defines this as SaveToCSV<T> where T: new()  but for some reason
    // the event can't be setup.  This was the suggested fix I found it appears later in the 
    // lesson that this is actually done.
    public void SaveToCSV(List<T> items, string filePath)
    {
        List<string> rows = new List<string>();

        T entry = new T();

        var cols = entry.GetType().GetProperties();

        string row = "";

        foreach (var col in cols)
        {
            row += $", {col.Name}";
        }

        row = row.Substring(1);

        rows.Add(row);

        foreach (var item in items)
        {
            row = "";
            bool badWordDetected = false;

            foreach (var col in cols)
            {
                string val = col.GetValue(item, null).ToString();

                badWordDetected = BadWordDetector(val);

                if (badWordDetected == true)
                {
                    BadEntryFound?.Invoke(this, item);
                    break;
                }

                row += $", {val}";
            }

            if (badWordDetected == true)
            {
                continue;
            }
            row = row.Substring(1);

            rows.Add(row);
        }

        File.WriteAllLines(filePath, rows);
    }

    private bool BadWordDetector(string stringToTest)
    {
        bool output = false;
        var lowerCaseTest = stringToTest.ToLower();
        if (lowerCaseTest.Contains("darn") || lowerCaseTest.Contains("heck"))
        {
            output = true;
        }

        return output;
    }
}