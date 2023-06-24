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
using PersonAddressLibrary.Framework.Addresses;
using PersonAddressLibrary.Framework.AddressTypes;

namespace AddressForms
{
    public partial class AddPerson : Form, ISaveAddress
    {
        private ISavePersonModel _parent;
        BindingList<IPersonAddressModel> Addresses = new BindingList<IPersonAddressModel>();
        public AddPerson(ISavePersonModel parent)
        {
            InitializeComponent();
            _parent = parent;

        }

        private void GoBackAddPersonButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddressButton_Click(object sender, EventArgs e)
        {
            using (AddPersonAddress newAddressForm = new AddPersonAddress(this))
            {
                if (newAddressForm.ShowDialog() == DialogResult.OK)
                {
                    AddressListBox_BindToAddresses();
                }
            }
        }

        public void SaveAddress(IPersonAddressModel address)
        {
            Addresses.Add(address);
        }

        private void AddressListBox_BindToAddresses()
        {
            addressesListBox.Items.Clear();

            int addressCount = 1;
            foreach (var address in Addresses)
            {
                string fullAddress = address.FullAddress;

                addressesListBox.Items.Add(fullAddress);
            }
        }

        private void savePersonButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;

            List<IPersonAddressModel> addresses = Addresses.ToList();

            PersonModel person = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Addresses = addresses
            };

            _parent.SavePerson(person);
            this.Close();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            //addressesListBox.DataSource = Addresses;
            //addressesListBox.DisplayMember = "FullAddress";

            AddressListBox_BindToAddresses();
        }

        private void addressesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
