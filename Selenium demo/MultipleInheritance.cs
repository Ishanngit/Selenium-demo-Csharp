using System;

// single inheritance
class dep
{
    public void inh()
    {
        Console.WriteLine("This is single inheritance ");
    }
}

class clg : dep
{
    public void inh2()
    {
        Console.WriteLine("dep is inherited");
    }
}

// multi-level inheritance
class manager : dep
{
    public void Run()
    {
        Console.WriteLine("Manager calss");
    }
}




// multiple inheritance
interface T1
{
    void Method1();
}

interface T2
{
    void Method2();
}

class newclass : T1, T2
{
    public void method()
    {
        Console.WriteLine("Method is called.");
    }

    public void methodnew()
    {
        Console.WriteLine("method new is called.");
    }
}

// main program
class Program
{
    static void Main(string[] args)
    {
        // single inheritance
        dep obj = new dep();
        dep.inh();
        dep.inh2();

      

        // multiple inheritance
        MyClass myClass = new MyClass();
        myClass.Method1();
        myClass.Method2();

        
    }
}
