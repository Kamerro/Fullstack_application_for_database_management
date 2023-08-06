using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace WinFormsSQLIDE
{
    public partial class ConfigureWindow : Form
    {
      
        public ConfigureWindow()
        {
            InitializeComponent();
            CheckIfTheRegisterIsSet();
        }

        private void CheckIfTheRegisterIsSet()
        {
            string valServer = SystemRegistry.getRegistryKey("Server");
            string valBase = SystemRegistry.getRegistryKey("Database");
            string valTable = SystemRegistry.getRegistryKey("Table");
            if (valServer != "!@#<NoKey")
            {
                txtConnectionWithServer.Text = valServer;
                txtConnectionWithServer.Enabled = false;
            }
            if (valBase != "!@#<NoKey")
            {
                txtConnectionWithDatabase.Text = valBase;
                txtConnectionWithDatabase.Enabled = false;
            }
            if (valTable != "!@#<NoKey")
            {
                txtConnectionWithTable.Text = valTable;
                txtConnectionWithTable.Enabled = false;
            }
        }

        private void btnSearchServer_Click(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            // Pobierz DataTable, który zawiera informacje o wszystkich dostępnych instancjach SQL Server
            DataTable table = instance.GetDataSources();
            // Przejdź przez każdy wiersz w tabeli
            cbServer.Items.Clear();
            cbServer.Text = string.Empty;
            foreach (DataRow row in table.Rows)
            {
                cbServer.Items.Add(row["ServerName"].ToString() + @"\" + row["InstanceName"]?.ToString());
            }
        
        }

        private void btnSearchForDB_Click(object sender, EventArgs e)
        {
           //Server needed to be save in the registry windows before use "Search for the db"!
            string connectionString;
            connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable databases = connection.GetSchema("Databases");
                cbBase.Items.Clear();
                cbBase.Text = string.Empty;
                foreach (DataRow database in databases.Rows)
                {
                    string databaseName = database.Field<string>("database_name");
                    cbBase.Items.Add(databaseName);
                }
            }
        }

        private void btnSearchForTable_Click(object sender, EventArgs e)
        {
            string connectionString = $@"Data Source={SystemRegistry.getRegistryKey("Server")};
            Initial Catalog={SystemRegistry.getRegistryKey("Database")};Integrated Security=True;Connect Timeout=30;Encrypt=False;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                DataTable schema = connection.GetSchema("Tables");
                cbTable.Items.Clear();
                cbTable.Text = string.Empty;
                foreach (DataRow row in schema.Rows)
                {
                    cbTable.Items.Add(row[2]);
                }
            }
        }

        private void btnServerSave_Click(object sender, EventArgs e)
        {
            SystemRegistry.ModifyRegistry("Server", cbServer.SelectedItem.ToString());
            txtConnectionWithServer.Enabled = true;
            txtConnectionWithServer.Text = cbServer.SelectedItem.ToString();
            txtConnectionWithServer.Enabled = false;
            cbServer.Items.Clear();
            cbServer.Text = string.Empty;
        }

        private void btnSaveDB_Click(object sender, EventArgs e)
        {
            SystemRegistry.ModifyRegistry("Database", cbBase.SelectedItem.ToString());
            txtConnectionWithDatabase.Enabled = true;
            txtConnectionWithDatabase.Text = cbBase.SelectedItem.ToString();
            txtConnectionWithDatabase.Enabled = false;
            cbBase.Items.Clear();
            cbBase.Text = string.Empty;
        }

        private void btnSaveTable_Click(object sender, EventArgs e)
        {
            SystemRegistry.ModifyRegistry("Table", cbTable.SelectedItem.ToString());
            txtConnectionWithTable.Enabled = true;
            txtConnectionWithTable.Text = cbTable.SelectedItem.ToString();
            txtConnectionWithTable.Enabled = false;
            cbTable.Items.Clear();
            cbTable.Text = string.Empty;
        }
    }
}
