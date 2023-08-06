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
    public partial class MaintainTables : Form
    {
        public MaintainTables()
        {
            InitializeComponent();
        }

        private void btnAddtable_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"create table {txtTableName.Text}(id int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            txtTableName.ReadOnly = true;
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"ALTER TABLE {SystemRegistry.getRegistryKey("Table")} ADD " + txtColumnName.Text + " VARCHAR(50);";
                SqlCommand command = new SqlCommand(query, connection);
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //DataTable dataTable = new DataTable();
                //dataAdapter.Fill(dataTable);
                command.ExecuteNonQuery();
                //dataGridDB.RowHeadersVisible = false;
                //dataGridDB.DataSource = dataTable;
                //ShowData();
            }
        }

        private void btnSetCreatedTableAsSelectedTable_Click(object sender, EventArgs e)
        {
            SystemRegistry.ModifyRegistry("Table", txtTableName.Text);
        }

        private void btnRemoveColumnFromTable_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $"ALTER TABLE {SystemRegistry.getRegistryKey("Table")} drop column " + txtColumnName.Text;
                SqlCommand command = new SqlCommand(query, connection);
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                //DataTable dataTable = new DataTable();
                //dataAdapter.Fill(dataTable);
                command.ExecuteNonQuery();
                //dataGridDB.RowHeadersVisible = false;
                //dataGridDB.DataSource = dataTable;
                //ShowData();
            }
        }
    }
}
