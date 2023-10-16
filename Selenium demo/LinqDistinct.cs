
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
    public class LinqDistinct
    {

  public static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() {

                10,20,20,30,40,40,10,50,60
       };

            var result = Numbers.Distinct();

            foreach (var distinct in result)
            {
                Console.WriteLine(distinct + " ");
            }
        }
    }
}
