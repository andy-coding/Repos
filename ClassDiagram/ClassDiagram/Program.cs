using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyClass();
            obj.Prop1 = 7;
            Console.WriteLine(obj.Prop1);
        }
    }

    class MyClass
    {
        private int prop1;

        public int Prop1 { get
            {
                return prop1;
            }

            set
            {
                prop1 = value;
            }
        }

    }
}
