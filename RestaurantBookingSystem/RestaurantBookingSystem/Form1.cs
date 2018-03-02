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

namespace RestaurantBookingSystem
{
    public partial class Form1 : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RestaurantBookingSystem.Properties.Settings.BookingDBConnectionString"].ConnectionString;


        public Form1()
        {
            InitializeComponent();
        }

        private void ShowTables()
        { 
            string query = "SELECT TableNumber as 'Table Number', NumberofChairs AS 'Chairs' FROM Tables";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();


                SqlDataReader reader = command.ExecuteReader();

                lbShowTables.Items.Clear();

                if (reader.HasRows)
                {
                    pnlShowTables.Visible = true;

                    while (reader.Read())
                    {
                        lbShowTables.Items.Add(reader["Table Number"].ToString() +
                        "\t\t" + reader["Chairs"].ToString());
                    }
                }
                else MessageBox.Show("No tables have beend defined yet.");
            }
        } // end ShowTables method

        private void BtnDefine_restaurant_Click(object sender, EventArgs e)
        {
            NewTable newTable = new NewTable();
            newTable.Show();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnListTables_Click(object sender, EventArgs e)
        {
            ShowTables();
        }


    }
}
