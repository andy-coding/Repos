using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABtrash
{
    /// <summary>
    /// Manages user accounts
    /// </summary>
    public class User
    {
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get; set; }

        public string FullName()
        {
            return this.FirstName + " " + this.LastName;
        }

    }
}
