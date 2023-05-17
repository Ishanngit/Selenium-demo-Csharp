using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class Inheritance : UnitTest3
    {
        [TestMethod]
        public void Inh()
        {
            UnitTest3 unit = new UnitTest3();
            Console.WriteLine(unit.car);

        }
       
    }
}
