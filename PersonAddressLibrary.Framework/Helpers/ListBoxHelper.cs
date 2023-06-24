using System.Windows.Forms;

namespace PersonAddressLibrary.Framework.Helpers
{
    public static class ListBoxHelper
    {
        public static void UpdateListBox(this ListBox listBox, string message)
        {
            listBox.Items.Add(message);
        }

    }
}