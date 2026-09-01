using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab22
{

    // Write a C# program to demonstrate Method Overriding using virtual and override keywords.
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog();

            animal.Sound();
        }
    }

    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
    }
}
