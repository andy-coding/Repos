using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStore
{
    public class Warehouse 
    {

        #region Constructors
        public Warehouse(string name)
        {
            Name = name;
        }
        #endregion

        #region Props: Name
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion 



    }


    
}
