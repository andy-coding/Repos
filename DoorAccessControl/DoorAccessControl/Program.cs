using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoorAccessControl
{

    class Program // Program class
    {
            static void Main(string[] args) //main method
            {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());


                //SalesManager objsales = new SalesManager();
                //EmployeeCard objcard = new EmployeeCard();
                //objsales.IsActive = "Y"; //This value can be set from database
                //if (objsales.AuthorizeMe(objcard) == true)
                //{
                //    Console.WriteLine("Manager is been entered in the company");
                //}
                //else
                //{
                //Console.WriteLine("Manager is not been entered in the company");
                //}


            //try
            //{
            //    string conn = @"Server=192.168.1.17\SQLEXPRESS;Database=db1;UID=stduser;password=userstd";

            //    SQL.CreateCommand(@"Select * FROM [Table]", conn);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error! " + e.ToString());
            //}
            } // end method

    } // end class
}
