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


    public partial class NewTable : Form
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["RestaurantBookingSystem.Properties.Settings.BookingDBConnectionString"].ConnectionString;


        public NewTable()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            int intTableNumber = 0;
            int intNoOfSeats = 0;

            try
            {

                int ignoreMe;

                if ((Int32.TryParse(txtTableNumber.Text, out ignoreMe)) && (Int32.TryParse(txtNumberOfSeats.Text, out ignoreMe)))
                {
                    Table tbl = new Table(intTableNumber, intNoOfSeats);

                    string query = "INSERT INTO Tables VALUES (@TableNumber, @NumberofSeats)";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        command.Parameters.AddWithValue("@TableNumber", txtTableNumber.Text);
                        command.Parameters.AddWithValue("@NumberofSeats", txtNumberOfSeats.Text);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Table added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
            
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task cencelled");
            this.Close();
        }


    }
}
