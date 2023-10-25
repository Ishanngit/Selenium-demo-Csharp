using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_demo
{
    [TestClass]
    public class patient
    {
        public patient()
        {
        }
        // Fields  
        private string _name;
        private int _age;
        private string _gender;
        private string _area;
        // Properties  
        public string PatientName
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }
        public String Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
    }
}