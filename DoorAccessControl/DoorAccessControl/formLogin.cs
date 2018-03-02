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

namespace DoorAccessControl
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public string connString = @"Data Source=192.168.1.17\SQLEXPRESS;Initial Catalog=db1;Integrated Security=False;User ID=sa;Password=Fruity5678;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(connString);
            string query = "Select * from accounts where [user] = '" 
                + txtName.Text.Trim() + "' and [password] = '" + txtPassword.Text.Trim() + "'";
            //Console.WriteLine(query);

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);

            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count ==1)
            {
                FormMainMenu objFormMainMenu = new FormMainMenu();
                this.Hide();
                objFormMainMenu.Show();

            }
            else
            {
                MessageBox.Show("Check your username and password");
            }
            
            //con.Open();

            //if (con.State == System.Data.ConnectionState.Open)
            //{
            //    string q = "INSERT INTO Table(user,password) VALUES ('" + txtName.Text.ToString() + "','" + txtPassword.Text.ToString() + "')";
            //    SqlCommand cmd = new SqlCommand(q, con);
            //}


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
