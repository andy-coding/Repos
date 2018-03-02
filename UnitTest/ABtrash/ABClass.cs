using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABtrash
{
    class ABClass
    {
        public ABClass()
        {

        }


        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set {
                var trimmedName = value.Trim();
                firstName = trimmedName;
            }
        }

        public string LastName { get; set; }


    }
}
