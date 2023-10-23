
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
    public class LamdaLinq
    {

        [TestMethod]
        public void linq()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //select filter using lamda
            var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

            Console.WriteLine("Even Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }
        [TestMethod]
        public void linqodd()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //select odd using lamda
            
            var oddNumbers = numbers.Where(x => x % 2 != 0).ToList();

            Console.WriteLine("Odd Numbers:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
        [TestMethod]
        public void SortingNumbers()
        {
            List<int> numbers = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };

            var oddNumbers = numbers.OrderBy(x => x).ToList();


            Console.WriteLine("Sorted Nuumbers are:");
            foreach (var number in oddNumbers)
            {
                Console.WriteLine(number);
            }
        }
        [TestMethod]
        public void Length()
        {
            var fruits = new List<string> { "apple", "banana", "cherry", "date" };
            var longFruits = fruits.Where(fruit => fruit.Length > 5).ToList();


            Console.WriteLine("The fruit list length having more than 5");
            foreach (var number in longFruits)
            {
                Console.WriteLine(number);
            }
        }
        [TestMethod]
        public void SortingCharacters()
        {
            var names = new List<string> { "Ishan", "Yuvraj", "Japlan", "Rahil" };
            var sortedNames = names.OrderBy(name => name.Length).ToList();

            Console.WriteLine("The sorted characters are");
            foreach (var number in sortedNames)
            {
                Console.WriteLine(number);
            }
        }
        [TestMethod]
        public void AddNum()
        {
            Func<int, int> addOne = x => x + 1;
            int result = addOne(7); 

            Console.WriteLine("The Total is"+result);
           
        }
    }
}
