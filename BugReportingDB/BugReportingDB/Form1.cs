using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;



namespace BugReportingDB
{
    public partial class Form1 : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugReportingDB.Properties.Settings.BugReportingDatabaseConnectionString"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bugReportingDatabaseDataSet.tblProject' table. You can move, or remove it, as needed.
            this.tblProjectTableAdapter.Fill(this.bugReportingDatabaseDataSet.tblProject);

            string query = "Select a.dbBugId AS 'Bug ID', b.dbProjectName AS 'Project', c.dbBugCategory AS 'Bug Category' from tblBug a " +
                "INNER JOIN tblProject b ON (a.dbProjectid = b.dbProjectid) " +
                "INNER JOIN tblBugCategory c on (a.dbBugCategoryId = c.dbBugCategoryId)";


            using (SqlConnection myconnection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, myconnection))
            {
                //display bugs
                myconnection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(reader);

                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("No rows found");
                }
             myconnection.Close();

            } //end connection

        } // end Form1 load

        private void ListProjectdetails()
        {
            string query = "SELECT * FROM tblProject WHERE dbProjectId = @dbProjectId";

            using (SqlConnection connect = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connect))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@dbProjectId", txtSearchProjectId.Text);
            }
        } // end ListProjectDetails

        private void button1_Click(object sender, EventArgs e)
        {
            NewProject Form2 = new NewProject();
            Form2.Show();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            NewProject newProjectForm = new NewProject();
            newProjectForm.Show();
        }

        private void btnListProjects_Click(object sender, EventArgs e)
        {
            // ListProjects listProj = new ListProjects();
         //   listProj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
