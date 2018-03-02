using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassC : ClassB
    {
        public ClassC(string name) : base(name)
        {
            Name = name;
            Console.WriteLine("ClassC created");
        }
    }
}
