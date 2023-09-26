
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
        String[] a = { "This is test", "Array of string", "Multiple", "Ishan" };
        int[] b = { 1, 2, 3 };
        [TestMethod]
        public void arraytest()
        {
            String[] a1 = new String[4];
            a1[0] = "Ishan";
           // a2[1] = "Test";

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
              //  if (i == 0)
            }
        }
    }
}
