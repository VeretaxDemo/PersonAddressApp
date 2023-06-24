using Newtonsoft.Json;
using PersonAddressLibrary.Framework.Models;
using Formatting = System.Xml.Formatting;

namespace DataManagementLibrary.Extensions;

public static class PersonExtensions
{
    public static void SaveAsJson(this PersonModel person, string filePath)
    {
        string json = JsonConvert.SerializeObject(person, (Newtonsoft.Json.Formatting)Formatting.Indented);
        File.WriteAllText(filePath, json);
    }

    public static void SaveAsJson(this List<PersonModel> list, string filePath)
    {
        string json = JsonConvert.SerializeObject(list, (Newtonsoft.Json.Formatting)Formatting.Indented);
        File.WriteAllText(filePath, json);
    }
}