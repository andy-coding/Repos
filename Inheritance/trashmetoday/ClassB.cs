using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class ClassB : ClassA
    {
        public ClassB(string name) : base (name) 
        {

            base.Name = name;
            Console.WriteLine("ClassB created");
        }

        public override void Walk()
        {
            base.Walk();

            //Console.WriteLine(this.Name + "(this) walked.");
            //Console.WriteLine(base.Name + "(base) walked.");
        }

        public void BaseWalk()
        {
            base.Walk();
        }
    }
}
