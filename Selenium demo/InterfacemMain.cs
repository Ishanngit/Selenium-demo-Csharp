using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class InterfacemMain
    {
        [TestMethod]
        public void Int() 
        { 
            Interface3 obj = new Interface3();
            obj.mymethod();
            obj.Mymethodtwo();


        }
    }
}
