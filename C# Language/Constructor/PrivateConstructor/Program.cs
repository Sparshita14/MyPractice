using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateConstructor
{
    public class Fruit
    {
        public int i;
        public string fruit;
        private Fruit(int i, string fruit)
        {
            this.i = i;
            this.fruit = fruit;
            Console.WriteLine("Private constructor");
        }

        public static void la()
        {
            Console.WriteLine("lalala");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Fruit.la();
           
        }
    }
}
