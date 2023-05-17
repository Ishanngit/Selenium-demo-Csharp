using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class Polymorphism
    {
        [TestMethod]
        public void testPolymorphism() 
        {
            Class1 class1 = new Class1();
            Class1 class2 = new Class2();
            Class1 class3 = new Class3();

            class1.Classtest();
            class2.Classtest();
            class3.Classtest();

        }
    }
}
