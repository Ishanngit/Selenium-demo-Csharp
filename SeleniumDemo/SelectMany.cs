using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class SelectMany
    {
        [TestMethod]
        public void linqtest()
        {
           
            List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "ishan", Courses = new List<string> { "csharp", "dotnet" } },
            new Student { Id = 2, Name = "yuvraj", Courses = new List<string> { "java", "python" } },
            new Student { Id = 3, Name = "jalpan", Courses = new List<string> { "android", "iOS" } },
        };

            
            var allCourses = students.SelectMany(student => student.Courses);

            
            Console.WriteLine("All Courses Taken:");
            foreach (var course in allCourses)
            {
                Console.WriteLine(course);
            }
        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; }
    }
}