using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorAccessControl
{
    public class EmployeeCard //class
    {
        public bool AuthorizeManager(SalesManager obj)
        {
            if (obj.IsActive == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    } // end class
}
