using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using PersonAddressLibrary.Framework;
using PersonAddressLibrary.Framework.Models;
using PersonAddressLibrary.Framework.Models.Addresses;

namespace AddressForms.WPF
{
    /// <summary>
    /// Interaction logic for Person_Entry.xaml
    /// </summary>
    public partial class Person_Entry : Window, ISaveAddress
    {

        private ISavePersonModel _parent;
        BindingList<IPersonAddressModel> Addresses = new BindingList<IPersonAddressModel>();

        public Person_Entry(ISavePersonModel parent)
        {
            InitializeComponent();
            _parent = parent;

            addressListBox.ItemsSource = Addresses;
        }

        private void addAddressButton_Click(object sender, RoutedEventArgs e)
        {
            PersonAddressEntry addressEntry = new PersonAddressEntry(this);
            addressEntry.Show();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void SaveAddress(IPersonAddressModel address)
        {
            Addresses.Add(address);


        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {

            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string email = emailTextBox.Text;

            PersonModel person = new PersonModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Addresses = this.Addresses.ToList(),
            };

            _parent.SavePerson(person);

            this.Close();
        }
    }
}
