using RentACarAgency.Communication;
using System;
using System.Windows.Forms;

namespace RentACarAgency
{

    public partial class AddForm : Form
    {
        private readonly IParent _parent;

        public AddForm(IParent parent)
        {
            InitializeComponent();
            _parent=parent;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
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
            else if (ph.ToString().Length<9)
            {
                MessageBox.Show("Enter correct phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _parent.NewClientCreated(new CLIENTS {
                    C_NAME = name,
                    SURNAME = surname,
                    PHONE_NUMBER = ph,
                    ADRESS = address
                });
                Close();
            }
        }
    }
}
