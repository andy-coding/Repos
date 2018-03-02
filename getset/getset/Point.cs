using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class Point
    {
        private int x;
        private int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        internal int X
        {
            get { return this.x; }
            set
            {
                while (value < 5)
                {
                    if (value < 5)
                    {
                        throw new ArgumentException("try again");
                    }
                }

                this.x = value;
            }
        }

        internal int Y
        {
            get { return this.y; }
            set { this.x = value; }
        }
        
 
    }
}
