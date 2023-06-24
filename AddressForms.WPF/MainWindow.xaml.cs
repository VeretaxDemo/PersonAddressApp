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

namespace AddressForms.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISavePersonModel
    {
        public BindingList<IPersonModel> people = new BindingList<IPersonModel>();
        public MainWindow()
        {
            InitializeComponent();

            this.peopleListBox.ItemsSource = people;
        }

        private void addPersonButton_Click(object sender, RoutedEventArgs e)
        {
            Person_Entry newPersonEntry = new Person_Entry(this);


            newPersonEntry.Show();


            this.peopleListBox.ItemsSource = this.people;
        }

        public void SavePerson(IPersonModel person)
        {
            people.Add(person);

        }
    }
}
