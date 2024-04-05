using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticConstructor
{
    public class Fruit
    {
        public int i;
        public string fruit;
        // will have no parameters
         static Fruit()
        {
         
            Console.WriteLine("static constructor");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit();
        }
    }
}
