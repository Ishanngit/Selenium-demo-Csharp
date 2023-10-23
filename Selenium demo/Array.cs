
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class Array
    {
        String[] array1 = { "This is test", "Array of string", "Multiple", "Ishan" };
        int[] array2 = { 1, 2, 3 };
        [TestMethod]
        public void arraytest()
        {
            String[] array1 = new String[4];
            array1[0] = "Ishan";
           // a2[1] = "Test";

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
              //  if (i == 0)
            }
        }
    }
}
