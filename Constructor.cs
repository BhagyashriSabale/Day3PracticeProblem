using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3PracticeProblem
{
    internal class Constructor
    {
      
            public string Name { get; set; }
            public int Age { get; set; }
            //Default Constuctor
            public Constructor()
            {
              Name = "Unknown";
              Age = 0;
            }
            //Parameterised Constuctor    
            public Constructor(string name, int age)
            {
              Name = name;
              Age = age;
            }
            //Cpoy Constuctor
            public Constructor(Constructor otherPerson)
            {
              Name = otherPerson.Name;
              Age = otherPerson.Age;
            }
            public void Display()
            {
              Console.WriteLine("Name: " + Name);
              Console.WriteLine("Age: " + Age);
            }


    }
}
