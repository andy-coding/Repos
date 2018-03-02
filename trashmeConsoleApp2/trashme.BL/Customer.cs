using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trashmeConsoleApp2
{
    class Customer
    {
        public int CustomerId { get; set; }
        private string name;

        public string Name
        {
            get { return name; }
            set {
                    if (!string.IsNullOrWhiteSpace(value))
                    name = value;
                }
        }

        public bool Validate()
        {
            var status = true;
            if (string.IsNullOrWhiteSpace(Name)) status = false;
            return status;
        }
    }
}
