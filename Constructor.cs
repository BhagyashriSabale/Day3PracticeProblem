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
            public Constructor()
            {
              Name = "Unknown";
              Age = 0;
            }
            public Constructor(string name, int age)
            {
              Name = name;
              Age = age;
            }
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
