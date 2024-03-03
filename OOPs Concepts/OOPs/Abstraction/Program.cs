using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public abstract class Fruits // abstract class 
    {
        public abstract void nameof(string fruit); // abstract method with no body

        public void nonab() // non abstract method with body
        {
            Console.WriteLine("this is non abstract class");
        }

        public virtual void nometh()
        {
            Console.WriteLine("this is parent");
        }
    }

    public class Apple : Fruits
    {
        public override void nameof(string fruit) { // body for parent abstract method
            Console.WriteLine("the fruit is apple->"+fruit);
        }

        public override void nometh()
        {
            base.nometh();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            apple.nameof("its apple"); // calling the child override method

            apple.nonab(); // calling parent non abstract method from child object

            apple.nometh(); // base method assigned in child
        }
    }
}
