using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3PracticeProblem
{
    internal class AccessSpecifiers
    {
        private string name; // private field
        public int age; // public field
        protected string address;// protected field
        public AccessSpecifiers(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        private void DisplayPrivateInfo() // private method
        {
            Console.WriteLine("Name: " + name);
        }
        public void DisplayPublicInfo() // public method
        {
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Address: " + address);
        }
        protected void DisplayProtectedInfo() // protected method
        {
            Console.WriteLine("Protected Address: " + address);
        }
       
            public void DisplayEmployeeInfo()
            {
                Console.WriteLine("Employee Details:");
                Console.WriteLine("Name: " + name); // Error: 'name' is private in Person
                Console.WriteLine("Age: " + age);
                Console.WriteLine("Address: " + address); // Error: 'address' is protected in Person
                DisplayProtectedInfo(); // Accessible because it's a protected method from the base class
            }
        
    }
}
