using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABProj
{
    public class User
    {
        /// <summary>
        /// Manages users within the ABProj project
        /// </summary>
        
        public User()
        {

        }

        public User(string firstName, string lastName): this()
        {
            this.FirstName = firstName;
            this.Lastname = lastName;
        }

        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value.Trim(); }
        }

        private string lastName;

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value.Trim(); }
        }

        public string FullName => FirstName + " " + Lastname;

        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public bool UpdateUser(string firstName, string lastName)
        {
            Console.Write("Enter new first name: ");
            string newFirstname = Console.ReadLine();

            Console.Write("Enter new last name: ");
            string newLastname = Console.ReadLine();

            try
            {
                this.FirstName = newFirstname;
                this.Lastname = newLastname;
                Console.WriteLine(this.FullName + " has been created.");
                return true;
            }

            catch
            {
                return false;
            }  
            
        } // end method
    } // end class
}
