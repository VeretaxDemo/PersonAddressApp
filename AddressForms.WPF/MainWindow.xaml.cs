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
using System.Windows.Navigation;
using System.Windows.Shapes;
using PersonAddressLibrary.Framework;
using PersonAddressLibrary.Framework.Models;
using DataManagementLibrary.Extensions;

namespace AddressForms.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISavePersonModel, INotifyPropertyChanged
    {
        private BindingList<IPersonModel> _people = new BindingList<IPersonModel>();

        public BindingList<IPersonModel> People
        {
            get { return _people; }
            set
            {
                _people = value;
                OnPropertyChanged(nameof(People));
                UpdateExportAllButtonState();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isExportAllEnabled = false;
        public bool IsExportAllEnabled
        {
            get { return _isExportAllEnabled; }
            set
            {
                _isExportAllEnabled = value;
                OnPropertyChanged(nameof(IsExportAllEnabled));
            }
        }
        public MainWindow()
        {
            InitializeComponent();

            People.ListChanged += People_ListChanged; // Subscribe to the ListChanged event

            this.peopleListBox.ItemsSource = People;

            DataContext = this;
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateExportAllButtonState()
        {
            if (People != null)
            {
                IsExportAllEnabled = People.Count() >= 1 ? true : false;
                exportAllButton.IsEnabled = true;
            }
            else
            {
                IsExportAllEnabled = false;
                exportAllButton.IsEnabled = false;
            }
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            People.ListChanged += People_ListChanged;
        }

        private void AddPersonButton_Click(object sender, RoutedEventArgs e)
        {
            Person_Entry newPersonEntry = new Person_Entry(this);


            newPersonEntry.Show();


            this.peopleListBox.ItemsSource = this.People;
        }

        public void SavePerson(IPersonModel person)
        {
            People.Add(person);

            // Call the UpdateExportAllButtonState method after adding the first person
            if (People.Count >= 1)
            {
                UpdateExportAllButtonState();
            }

        }

        private void ExportAllButton_Click(object sender, RoutedEventArgs e)
        {
            if (People.Count == 0)
            {
                MessageBox.Show("There are no persons to export.", "Export All", MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            Microsoft.Win32.SaveFileDialog saveFileDialog = new Microsoft.Win32.SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";

            if (saveFileDialog.ShowDialog() == true)
            {
                string filePath = saveFileDialog.FileName;
                List<PersonModel> allPersons = People.Cast<PersonModel>().ToList();
                allPersons.SaveAsJson(filePath);
            }
        }

        private void People_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateExportAllButtonState();
        }
    }
}
