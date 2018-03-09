   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousDemo
{
    class Worker
    {
        public Worker()
        {
            Work();
        }

        public void Work()
        {
            AsyncClass asyncClassobj = new AsyncClass();
            asyncClassobj.Work();
            Console.Write("I'm on the main thread.");
            for (int i=0; i<1000; i++)
            {
                Console.Write(".");
            }
        }
    }

    public class AsyncClass
    {
        public async void Work()
        {
            await SlowTask();
            Console.WriteLine("End Work!");
        }

        public async Task SlowTask()
        {
            for (int i=0; i<50; i++)
            {
                Console.WriteLine(i);
                for (int j=0; j<1000; j++)
                {
                    var k = Math.Sqrt(j);
                }

            }
            Console.WriteLine("Done");
        }
    }

}
