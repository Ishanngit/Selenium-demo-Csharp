using Selenium_demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    public class Interface3 : Interface, Interface2

    {
       public void mymethod()
        {
            {
                Console.WriteLine("This is My method");
            }   
        }
            
        public void Mymethodtwo()
        {
            {
                Console.WriteLine("This is My method two");
            }
        }
    }

}

