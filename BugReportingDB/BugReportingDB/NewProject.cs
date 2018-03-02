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
    public partial class NewProject : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BugReportingDB.Properties.Settings.BugReportingDatabaseConnectionString"].ConnectionString;

        public NewProject()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tblProject VALUES (@dbProjectName, @dbProjectCode) ";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter sda = new SqlDataAdapter(command))
                {
                    connection.Open();
                    if (txtNewProjectName.Equals("") || txtNewProjectCode.Equals(""))
                    {
                        MessageBox.Show("Empty value entered");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@dbProjectName", txtNewProjectName.Text);
                        command.Parameters.AddWithValue("@dbProjectCode", txtNewProjectCode.Text);

                        command.ExecuteNonQuery();
                        MessageBox.Show("Project added sucessfully");
                        this.Close();
                    }


                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
