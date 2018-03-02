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

namespace Cookbook
{
    public partial class Cookbook : Form
    {
        SqlConnection connection;
        string connectionString;

        public Cookbook()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Cookbook.Properties.Settings.CookbookConnectionString"].ConnectionString;
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            label2.Text = connectionString;
            PopulateRecipes();
        }

        private void PopulateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Recipe", connection))
            {
                connection.Open();
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

               // lstRecipes.DisplayMember = "Inent";
                //lstRecipes.ValueMember = "IngredientId";
                listBox1.DataSource = recipeTable;
                label2.Text = connectionString;
            }

        }
    }
}
