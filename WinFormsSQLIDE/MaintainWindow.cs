using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsSQLIDE
{
    public partial class MaintainWindow : Form
    {
        public MaintainWindow()
        {
            InitializeComponent();
        }

        private void createDB_Click(object sender, EventArgs e)
        {
            //Server needed to be save in the registry windows before use "Search for the db"!
            string connectionString;
            connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"Create database {txtDatabaseName.Text}";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            txtDatabaseName.ReadOnly = true;
            deleteDB.Enabled = false;
        }

        private void deleteDB_Click(object sender, EventArgs e)
        {
            //Server needed to be save in the registry windows before use "Search for the db"!
            string connectionString;
            connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"drop database {txtDatabaseName.Text}";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SystemRegistry.ModifyRegistry("Database", txtDatabaseName.Text);
        }
    }
}
