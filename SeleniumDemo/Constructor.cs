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
            Constructor cons = new Constructor();
            Console.WriteLine(cons.model);

        }

    }
}
