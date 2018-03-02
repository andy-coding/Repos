using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        double currentValue = 0;
        string lastOperator = "";
        double total = 0;
        bool operatorSelected = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Number(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (operatorSelected == true)
            {
                txtDisplay.Text = "";
                operatorSelected = false;
            }

            if (txtDisplay.Text == "0")
                txtDisplay.Text = "";

            if (button.Text == "." && txtDisplay.Text.Contains("."))
                return;

            txtDisplay.Text = txtDisplay.Text + button.Text;

        }

        private void Btn_Operator(object sender, EventArgs e)
        {
            operatorSelected = true;
            Button soperator = (Button)sender;

            switch (soperator.Text)
            {
                case "+":
                    total = currentValue + Double.Parse(txtDisplay.Text);
                    break;

                case "_":
                    total = currentValue - Double.Parse(txtDisplay.Text);
                    break;

                case "*":
                    total = currentValue * Double.Parse(txtDisplay.Text);
                    break;

                case "/":
                    total = currentValue / Double.Parse(txtDisplay.Text);
                    break;
            }



            // tests:
            label2.Text = currentValue.ToString();
            label4.Text = soperator.Text;

            currentValue = total;
            txtDisplay.Text = total.ToString();


        }

        private void Btn_Clear(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            total = 0;
            currentValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }
    }
}
