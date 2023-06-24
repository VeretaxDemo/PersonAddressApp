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
using PersonAddressLibrary.Framework.Helpers;

namespace AddressForms
{
    public partial class Dashboard : Form, ISavePersonModel
    {
        
        public BindingList<IPersonModel> people = new BindingList<IPersonModel>();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void UpdatePersonList()
        {
            // Assuming you have a ListBox named "lstPerson" on your dashboard form.

            // Clear the ListBox to start with a fresh list
            peopleListBox.Items.Clear();
            // Add each person's name to the ListBox
            foreach (PersonModel person in people)
            {
                var message = ModelMessages.GetPersonFullName(person);

                peopleListBox.UpdateListBox(message);
            }
        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            using (AddPerson newPersonForm = new AddPerson(this))
            {
                if (newPersonForm.ShowDialog() == DialogResult.OK)
                {
                    PeopleListBox_BindToPeople();
                }
            }
                
        }

        private void PeopleListBox_BindToPeople()
        {
            peopleListBox.Items.Clear();

            foreach (var person in people)
            {
                string personString = person.DisplayPersonView;

                peopleListBox.Items.Add(personString);
            }
        }

        public void SavePerson(IPersonModel person)
        {
            people.Add(person);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PeopleListBox_BindToPeople();
        }
    }
}
