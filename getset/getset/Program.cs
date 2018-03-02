using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    class Program
    {
        static void Main()
        {
            Point thing = new Point(0,3);

            Console.Write("X = {0,6}Y = {1,6}\n", thing.X, thing.Y);

        }
    }
}
