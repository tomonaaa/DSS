using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class MainForm : Form
    {
        private List<PersionnalInformation> personalInformationList = new List<PersionnalInformation>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            string name = tBoxInputName.Text;
            string address = tBoxInputAddress.Text;
            int age;

            if (!int.TryParse(tBoxInputAge.Text, out age))
            {
                MessageBox.Show("Invalid age.");
            }

            string phone = tBoxInputPhone.Text;

            PersionnalInformation personalInformation = new PersionnalInformation(name, address, age, phone);
            personalInformationList.Add(personalInformation);

            tBoxInputName.Text = "";
            tBoxInputAddress.Text = "";
            tBoxInputAge.Text = "";
            tBoxInputPhone.Text = "";

            tBoxInputName.Focus();
        }

        private void btnSeeContacts_Click(object sender, EventArgs e)
        {
            InformationForm contactsForm = new InformationForm();

            for (int i = 0; i < personalInformationList.Count; i++)
            {
                contactsForm.lBoxOutContacts.Items.Add("Name: " + personalInformationList[i].Name.ToString());
                contactsForm.lBoxOutContacts.Items.Add("Address: " + personalInformationList[i].Address.ToString());
                contactsForm.lBoxOutContacts.Items.Add("Age: " + personalInformationList[i].Age.ToString());
                contactsForm.lBoxOutContacts.Items.Add("Job: " + personalInformationList[i].Phone.ToString());
                contactsForm.lBoxOutContacts.Items.Add("--------------------------");
            }
            this.Hide();
            contactsForm.ShowDialog();
        }

        private void btContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
