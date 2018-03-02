using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorAccessControl
{
    public class SalesManager //class
    {

        public string IsActive { get; set; } = "";

        public bool AuthorizeMe(EmployeeCard obj) // method
        {
            if (obj.AuthorizeManager(this) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        } // end method
    } // end class

}
