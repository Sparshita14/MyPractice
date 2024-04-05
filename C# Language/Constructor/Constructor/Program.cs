using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
   public class Fruit
    {
        public int i;
        public string fruit;
        public Fruit() {
            Console.WriteLine("Default constructor");
        }
    }

    public class Program
    {
        public static void Main(string[] args) { 
            
            // when object gets initialized, default constructor is called
            Fruit fruit = new Fruit();
            // it initializes the default value for the variables
            Console.WriteLine("i=>" + fruit.i);
            Console.WriteLine("fruit=>" + fruit.fruit);
        }
    }
}
