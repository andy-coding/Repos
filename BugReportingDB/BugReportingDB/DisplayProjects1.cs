using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace BugReportingDB
{
    public partial class DisplayProjects1 : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BugReportingDB.Properties.Settings.BugReportingDatabaseConnectionString"].ConnectionString;

        public DisplayProjects1()
        {
            InitializeComponent();
            ListProjectsInGrid();
        }

        private void ListProjectsInGrid()
        {
            try
            {
                string query = "SELECT * FROM tblProject";

                using (SqlConnection connect = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connect))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {

                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


