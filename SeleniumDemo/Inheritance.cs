using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class Inheritance : Obj2
    {
        [TestMethod]
        public void Inh()
        {
            Obj2 unit = new Obj2();
            Console.WriteLine(unit.car);

        }
        
    }
}
