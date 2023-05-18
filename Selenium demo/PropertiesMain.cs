using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class PropertiesMain
    {
        [TestMethod]
       public void properties()
        {
            Properties obj = new Properties();
            obj.Name = "This is property";
            Console.WriteLine(obj.Name);
        }
    }
}

