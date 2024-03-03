using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism

{
    public class Fruit// parent class
    {

        public virtual void declare() // method without parameter
        {
            Console.WriteLine("this is fruits");
        }

        public virtual void declare(string name) // with parameter
        {
            Console.WriteLine("this is from string "+name);
        }
    }

    public class Apple : Fruit // child class
    {
        public string frt = "apple";
        public override void declare() 
        {
            Console.WriteLine("this is apple");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
            Apple apple = new Apple();

            // method overriding
            fruit.declare();
            apple.declare();

            // method overloading
            fruit.declare("Hello");
            



        }
    }
}

