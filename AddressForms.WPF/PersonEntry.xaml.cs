using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using AddressForms.WPF.Annotations;
using PersonAddressLibrary.Framework;
using PersonAddressLibrary.Framework.Models;
using PersonAddressLibrary.Framework.Models.Addresses;
using DataManagementLibrary.Extensions;

namespace AddressForms.WPF
{
    /// <summary>
    /// Interaction logic for Person_Entry.xaml
    /// </summary>
    public partial class Person_Entry : Window, ISaveAddress, INotifyPropertyChanged
    {

        private ISavePersonModel _parent;
        BindingList<IPersonAddressModel> Addresses = new BindingList<IPersonAddressModel>();



        private bool _isExportEnabled;
        public bool IsExportEnabled
        {
            get { return _isExportEnabled; }
            set
            {
                _isExportEnabled = value;
                OnPropertyChanged(nameof(IsExportEnabled));
            }
        }

        private void UpdateExportButtonState()
        {
            IsExportEnabled = !string.IsNullOrEmpty(FirstName) &&
                              !string.IsNullOrEmpty(LastName) &&
                              !string.IsNullOrEmpty(Email);
        }

        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                UpdateExportButtonState();
            }
        }

        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                UpdateExportButtonState();
            }
        }

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                UpdateExportButtonState();
            }
        }

        public Person_Entry(ISavePersonModel parent)
        {
            InitializeComponent();
            _parent = parent;

            addressListBox.ItemsSource = Addresses;

            DataContext = this;
        }

        //private void OnPropertyChanged(string propertyName)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        private void AddAddressButton_Click(object sender, RoutedEventArgs e)
        {
            PersonAddressEntry addressEntry = new PersonAddressEntry(this);
            addressEntry.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void SaveAddress(IPersonAddressModel address)
        {
            Addresses.Add(address);


        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            var person = PreparePersonModel();

            _parent.SavePerson(person);

            this.Close();
        }

        private PersonModel PreparePersonModel()
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
            return person;
        }

        private void ExportButton_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = PreparePersonModel();

            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";


            // Generate the suggested filename using the format "lastname.firstname.json"
            string suggestedFileName = $"{person.LastName}.{person.FirstName}.json";
            saveFileDialog.FileName = suggestedFileName;

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                person.SaveAsJson(filePath);
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
