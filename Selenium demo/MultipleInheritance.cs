using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Selenium_demo
{
    [TestClass]
    // single inheritance
    class dep
    {
        public void inh()
        {
            Console.WriteLine("This is single inheritance ");
        }

        internal static void inh2()
        {
            throw new NotImplementedException();
        }
    }

    //class clg : dep
  //  {
     //   public void inh2()
      //  {
      //      Console.WriteLine("dep is inherited");
      //  }
  //  }

    // multi-level inheritance
    class manager : dep
    {
        public void Run()
        {
            Console.WriteLine("Manager calss");
        }
    }

    // multiple inheritance
    interface Test1
    {
        void Method1();
    }

    interface Test2
    {
        void Method2();
    }

    class newclass : Test1, Test2
    {
        public void method()
        {
            Console.WriteLine("Method is called.");
        }

        public void methodnew()
        {
            Console.WriteLine("method new is called.");
        }

        void Test1.Method1()
        {
            throw new NotImplementedException();
        }

        void Test2.Method2()
        {
            throw new NotImplementedException();
        }
    }

    // main program
    class Program
    {
        static void Main(string[] args)
        {
            // single inheritance
            dep obj = new dep();
           // dep.inh();
            dep.inh2();



            // multiple inheritance
            dep myClass = new dep();
          //  dep.inh();
            dep.inh2();

        }
    }
}