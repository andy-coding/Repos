using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace BugReportingDB
{

    public partial class ListProjects : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["BugReportingDB.Properties.Settings.BugReportingDatabaseConnectionString"].ConnectionString;
        
        private ListProjects()
        {
            InitializeComponent();
            DisplayProjects();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            NewProject newProject = new NewProject();
            newProject.Show();
        }

        private void DisplayProjects()
        {
            string query = "SELECT * FROM tblProject";

            try
            {
                    using (SqlConnection connect2 = new SqlConnection(connectionString))
                    using (SqlCommand command2 = new SqlCommand(query, connect2))
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command2))
                    {
                        DataTable ds = new DataTable();
                        adapter.Fill(ds);
                        dataGridView1.DataSource = ds;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } //end DisplayProjects

        //public void ListProjectsRefresh()
        //{
        //    this.Refresh();
        //}

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
