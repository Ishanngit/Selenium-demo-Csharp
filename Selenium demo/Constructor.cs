using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Configuration;
using System.Runtime.ConstrainedExecution;

namespace Selenium_demo
{
    [TestClass]
    public class Constructor
    {
        public string model;
        
        public Constructor()
        {
            model = "Honda";
        }
        [TestMethod]
        public void test()
        {
            Constructor c1 = new Constructor();
            Console.WriteLine(c1.model);

        }

    }
}
