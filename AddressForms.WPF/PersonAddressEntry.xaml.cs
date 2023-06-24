using PersonAddressLibrary.Framework.Addresses;
using PersonAddressLibrary.Framework.AddressTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PersonAddressLibrary.Framework.Helpers;

namespace AddressForms.WPF
{
    /// <summary>
    /// Interaction logic for PersonAddressEntry.xaml
    /// </summary>
    public partial class PersonAddressEntry : Window
    {
        private ISaveAddress _parent;

        public List<IAddressState> States = new List<IAddressState>();
        public List<AddressType> AddressTypes = new List<AddressType>();
        public List<PersonAddressModel> addresses = new List<PersonAddressModel>();
        public PersonAddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            this._parent = parent;


            States = StateList.US_States;
            
            string displayMember = "Name";
            string valueMember = "Abbreviation";

            stateDropdown.ItemsSource = States;

            HomeAddressType homeAddressType = new HomeAddressType();
            ShippingAddressType shippingAddressType = new ShippingAddressType();
            WorkAddressType workAddressType = new WorkAddressType();


            AddressTypes.Add(homeAddressType);
            AddressTypes.Add(shippingAddressType);
            AddressTypes.Add(workAddressType);

            string addressTypeDisplayName = "Name";
            string addressTypeDisplayValueMember = "Number";
            
            addressTypeDropdown.ItemsSource = AddressTypes;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            IAddressType addressType = (IAddressType)addressTypeDropdown.SelectedValue;


            var addressTypeNumber = addressType.GetAddressTypeNumber();
            
            string address1 = address1TextBox.Text;
            string address2 = address2TextBox.Text;
            string city = cityTextBox.Text;
            string zipCode = zipCodeTextBox.Text;
            IAddressState state = (IAddressState)stateDropdown.SelectedValue;

            IAddressState selectedState = state;

            IPersonAddressModel address = PersonModelHelper.PrepareAddressData(addressTypeNumber, address1, address2, city, selectedState, zipCode);

            _parent.SaveAddress(address);
            
            this.Close();
        }
        
    }
}
