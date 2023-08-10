using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class stringtest

    {
        [TestMethod]
       public void test()
        {
            Console.WriteLine("TEsting");
            int i = 5;
            Console.WriteLine("This is con data"+i);

            String name = "Ishaan";

            Console.WriteLine($"THis is test {name}");

            dynamic height = 5.9;
            Console.WriteLine($"The height is {height}");

            height = "The height";
            Console.WriteLine($"The new data {height}");

        }

    }

}
