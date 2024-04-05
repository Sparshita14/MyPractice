using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterizedConstructor
{
    public class Fruit
    {
        public int i;
        public string fruit;
        public Fruit(int i, string fruit)
        {
            this.i = i;
            this.fruit = fruit;
            Console.WriteLine("paramertized constructor");
        }
    }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            // used to initialize the values of the object
            Fruit fruit = new Fruit(1,"orange"); 
            Console.WriteLine("i=>" + fruit.i);
            Console.WriteLine("fruit=>" + fruit.fruit);

        }
    }
}
