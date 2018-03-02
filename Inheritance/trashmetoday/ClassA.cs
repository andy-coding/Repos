using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    partial class ClassA
    {
        public string Name
        { get; set; }

        public ClassA(string name)
        {
            Name = name;
            Console.WriteLine("ClassA created");
        }

        public virtual void Walk()
        {
            Console.WriteLine(this.Name + " walked.");
        }
    }
}
