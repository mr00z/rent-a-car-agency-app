using RentACarAgency.Communication;
using RentACarAgency.DAL;
using RentACarAgency.Persistance;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RentACarAgency
{
    public partial class MainForm : Form, IParent
    {
        private IDb _db;
        private IEnumerable<CLIENTS> _clients;
        private BindingSource _clientsSource, _carsSource, _ordersSource;
        private IEnumerable<CAR> _cars;
        private IEnumerable<ORDERS> _orders;
        private CLIENTS _selectedClient;

        public MainForm()
        {
            InitializeComponent();

            ClientsDataGridView.AutoGenerateColumns = false;
            CarsDataGridView.AutoGenerateColumns = false;
            OrdersDataGridView.AutoGenerateColumns = false;

            _db = new EfPersistance();
            LoadData();
        }

        private void LoadData()
        {
            _clients = _db.GetClients();
            _clientsSource = new BindingSource();
            _clientsSource.DataSource = _clients;

            ClientsDataGridView.DataSource = _clientsSource;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new AddForm(this);
            form.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            _selectedClient = ClientsDataGridView.SelectedRows[0].DataBoundItem as CLIENTS;
            var form = new EditForm(this, _selectedClient);
            form.ShowDialog();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {

            _orders = _db.GetOrders(MonthCalendar.SelectionRange.Start);
            _ordersSource = new BindingSource();
            _ordersSource.DataSource = _orders;

            OrdersDataGridView.DataSource = _ordersSource;
        }

        private void CarsMarksTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            _cars = _db.GetCars(e.Node.Text);
            _carsSource = new BindingSource();
            _carsSource.DataSource = _cars;

            CarsDataGridView.DataSource = _carsSource;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _selectedClient = ClientsDataGridView.SelectedRows[0].DataBoundItem as CLIENTS;
            DialogResult result = MessageBox.Show("Client will be permanently removed from the database.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                _db.RemoveClient(_selectedClient);
                LoadData();
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application for managing clients, cars and orders of car rental agency © Copyright Marcin Mróz 2017", 
                "Rent A Car Agency Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HowToAddClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To add a new client click \"Add Client\" button, enter the necessary data and click \"Add\" button.",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void HowToEditClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To edit a client, select client you want to edit and next click \"Edit Client\" button. " +
                "Then, edit the data you want and click \"Save\" button.",
               "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void HowToRemoveClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To remove a client, select client you want to remove and click \"Remove Client\" button.",
              "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        public void NewClientCreated(CLIENTS newClient)
        {
            _db.AddClient(newClient.C_NAME, newClient.SURNAME, (int)newClient.PHONE_NUMBER, newClient.ADRESS);
            LoadData();
        }

        public void EditedClient(string name, string surname, int phone_nr, string address)
        {
            _db.EditCLient(_selectedClient, name, surname, phone_nr, address);
            _db = new EfPersistance();
            LoadData();
        }
    }
}
