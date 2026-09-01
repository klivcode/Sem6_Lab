using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nccLab5
{
    public class Program
    {

        //5.  Write a C# program for showing single, multiple, multilevel and hierarchical inheritance
        static void Main(string[] args)
        {
            // create Object
            B singleI = new B();
            C multiplelevelI = new C();
            D hierarchicalI = new D();
            E multipleI = new E();

            //Single Inheritance
            Console.WriteLine(singleI.MethodA());
            Console.WriteLine(singleI.MethodB());

            // Multilevel Inheritance
            Console.WriteLine(multiplelevelI.MethodC());

            //Hierarchical Inheritance
            Console.WriteLine(hierarchicalI.MethodD());

            //Multiple Inheritance
            Console.WriteLine(multipleI.MethodA());
            Console.WriteLine(multipleI.MethodB());

            Console.ReadKey();
        }


    }



    // Parent Class | Base Clas
    public class A
    {
        public string MethodA()
        {
            return "Parent class Methd A";
        }
    }

    //Child Class
    // Single Inheritance
    // Inherits clas A
    public class B : A
    {
        public string MethodB()
        {
            return "Single Inheritance Method B";
        }
    }


    // Multilevel Inheritance
    // child class Inherits class B
    public class C : B 
    {
        public string MethodC()
        {
            return "Multilevel Inheritace Method C";
        }
    }


    //HIerarchical Inheritance
    // child class
    // Inherits class A
    public class D : A
    {
        public string MethodD()
        {
            return "Hierarchical Inheritance Method D";
        }

    }


    // Multiple Inheritance through multiple interfaces
    // using Interface

    interface IA
    {
        string MethodA();
    }

    interface IB
    {
        string MethodB();
    }

    public class E : IA, IB
    {
        // implements the method of Interface
        public string MethodA()
        {
            return "Multiple Inheritance MethodA";
        }

        public string MethodB()
        {
            return "Multiple Inheritance  MethodB";
        }
    }
}
