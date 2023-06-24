

namespace PersonAddressLibrary.Framework.Helpers
{
    public static class ComboBoxHelper
    {
        public static void BindComboBox(this System.Windows.Forms.ComboBox comboBox, object dataSource, string displayMember, string valueMember)
        {
            comboBox.DataSource = dataSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }

}
