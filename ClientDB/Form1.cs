using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientDB;

namespace ClientDB
{
    public partial class Form1 : Form
    {
        private ClientDB CDB;

        public Form1()
        {
            InitializeComponent();
            CDB = new ClientDB("Do Nothing Pty Ltd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddClient_Click(object sender, EventArgs e)
        {

            if (!CDB.AddClient(ClientNameTextBox.Text, Convert.ToInt32(Math.Round(ClientAgeBox.Value, 0))))
            {
                MessageBox.Show("Cannot add this client!");
            }
            else
                MessageBox.Show("Client added!");
        }

        private void RemoveClient_Click(object sender, EventArgs e)
        {
            if (!CDB.RemoveClient(ClientNameTextBox.Text))
                MessageBox.Show("Cannot remove this client!");
            else
                MessageBox.Show("Client removed!");
        }

        private void IsClient_Click(object sender, EventArgs e)
        {
            if (CDB.IsAClient(ClientNameTextBox.Text))
                MessageBox.Show("Our client!");
            else
                MessageBox.Show("Not our client!");
        }

        private void ListAll_Click(object sender, EventArgs e)
        {
            if (ClientsList.Items != null)
                ClientsList.Items.Clear();

            if (!CDB.ListAllClients(ClientsList.Items))
                MessageBox.Show("No clients in the database!");
            else
                MessageBox.Show(string.Format("Number of clients {0}", CDB.totalClients));
        }

        private void userInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void MemberLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
