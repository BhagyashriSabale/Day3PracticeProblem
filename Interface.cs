using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3PracticeProblem
{
    internal interface Interface1
    {
        void MakeSound();
    }
    public class Dog : Interface1
    {
        public void MakeSound() 
        {
            Console.WriteLine("Dog: Woof!");
        }
    }
    public class cat : Interface1
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat: Meow!");
        }
    }
}
