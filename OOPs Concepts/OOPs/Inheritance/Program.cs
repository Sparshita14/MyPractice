using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Fruit
    {

        public void declare()
        {
            Console.WriteLine("this is fruits");
        }
    }

    public class Apple : Fruit
    {
        public string frt = "apple";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.declare();
            Console.WriteLine("this is "+apple.frt);
        }
    }
}
