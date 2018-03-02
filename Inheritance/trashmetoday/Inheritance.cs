using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Inheritance
    {
        static void Main(string[] args)
        {

            var A = new ClassA("Name: A");
            ClassB B = new ClassB("Name: B");
            var C = new ClassC("Name: C");

            A.Walk();
            B.Walk();
            B.BaseWalk();
            C.Walk();

        }

    }


}
