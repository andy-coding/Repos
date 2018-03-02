using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    using Xunit;

    public class HelloWorldTest
    {
        [Fact]
        public void Say_hi_()
        {
            Assert.Equal("Hello, World!", HelloWorld.Hello());
        }
    }
}
