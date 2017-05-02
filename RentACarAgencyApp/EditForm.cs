using RentACarAgency.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACarAgency
{
    public partial class EditForm : Form
    {
        private readonly IParent _parent;
        private CLIENTS _client;

        public EditForm(IParent parent, CLIENTS clientToEdit)
        {
            _parent = parent;
            _client = clientToEdit;
            InitializeComponent();
            NameTextBox.Text = clientToEdit.C_NAME;
            SurnameTextBox.Text = clientToEdit.SURNAME;
            PhoneNrTextBox.Text = clientToEdit.PHONE_NUMBER.ToString();
            AddressTextBox.Text = clientToEdit.ADRESS;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            int ph;
            int.TryParse(PhoneNrTextBox.Text, out ph);
            string address = AddressTextBox.Text;

            if (name == null || name.Equals(""))
            {
                MessageBox.Show("Fill the name field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (surname == null || surname.Equals(""))
            {
                MessageBox.Show("Fill the surname field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (address == null || address.Equals(""))
            {
                MessageBox.Show("Fill the address field!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ph.ToString().Length < 9)
            {
                MessageBox.Show("Enter correct phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _parent.EditedClient(name, surname, ph, address);
                Close();
            }
        }
    }
}
