using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Selenium_demo
{
    [TestClass]
    public class ClassObj
    {
        [TestMethod]
        public void TestMethod1()
        {
            
           
            {
                 
                Obj1 obj = new Obj1();
                Obj2 obj1 = new Obj2();
                Console.WriteLine(obj.color);
                Console.WriteLine(obj1.car);
            }
        
                
    }
       
    }
   
}
