using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonAddressLibrary.Framework;
using PersonAddressLibrary.Framework.Extensions;
using PersonAddressLibrary.Framework.Helpers;
using PersonAddressLibrary.Framework.Models.Addresses;
using PersonAddressLibrary.Framework.Models.AddressTypes;

namespace AddressForms
{
    public partial class AddPersonAddress : Form
    {
        private ISaveAddress _parent;

        public List<IAddressState> States = new List<IAddressState>();
        public List<AddressType> AddressTypes = new List<AddressType>();
        public List<PersonAddressModel> addresses = new List<PersonAddressModel>();
        public AddPersonAddress(ISaveAddress parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void CancelAddressButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPersonAddress_Load(object sender, EventArgs e)
        {
            States = StateList.US_States;
            object stateDataSource = States;
            string displayMember = "Name";
            string valueMember = "Abbreviation";
            stateComboBox.BindComboBox(States, displayMember, valueMember);


            HomeAddressType homeAddressType = new HomeAddressType();
            ShippingAddressType shippingAddressType = new ShippingAddressType();
            WorkAddressType workAddressType = new WorkAddressType();


            AddressTypes.Add(homeAddressType);
            AddressTypes.Add(shippingAddressType);
            AddressTypes.Add(workAddressType);

            object addressTypeDataSource = AddressTypes;
            string addressTypeDisplayMember = "Name";
            string adddresTypeDisplayValueMember = "Number";

            addressTypeComboBox.BindComboBox(addressTypeDataSource, addressTypeDisplayMember, adddresTypeDisplayValueMember);
        }

        

        private void saveAddressButton_Click(object sender, EventArgs e)
        {
            IPersonAddressModel address = this.PrepareAddressData();

            _parent.SaveAddress(address);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private IPersonAddressModel PrepareAddressData()
        {
            int addressTypeNumber = (int)this.addressTypeComboBox.SelectedValue;

            string address1 = this.address1TextBox.Text;
            string address2 = this.address2TextBox.Text;
            string city = this.cityTextBox.Text;
            string zipCode = this.zipCodeTextBox.Text;

            IAddressState selectedState =
                this.States.Find(x => x.Abbreviation == this.stateComboBox.SelectedValue.ToString());

            switch (addressTypeNumber)
            {
                case 1:
                    HomePersonAddressModel homeAddress = new HomePersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState,
                    };

                    homeAddress.SelectAddressType(AddressType.AddressTypes.Home);

                    return homeAddress;

                    break;
                case 2:
                    ShippingPersonAddressModel shippingAddress = new ShippingPersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    shippingAddress.SelectAddressType(AddressType.AddressTypes.Shipping);

                    return shippingAddress;
                    break;
                case 3:
                    WorkPersonAddressModel workAddress = new WorkPersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    workAddress.SelectAddressType(AddressType.AddressTypes.Work);

                    return workAddress;
                    break;
                default:
                    HomePersonAddressModel homePersonAddress = new HomePersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    return homePersonAddress;
                    break;
            }
        }
    }
}
