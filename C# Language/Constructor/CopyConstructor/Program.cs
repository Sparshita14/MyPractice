using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    public class Fruit
    {
        public int i;
        public string fruit;
        public Fruit(Fruit f)
        {
            i= f.i;
            fruit = f.fruit;
        }

        public Fruit(int i, string fruits)
        {
            this.i = i;
            this.fruit = fruits;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Fruit(1,"apple");
            // maintaining copy of the object
            Fruit fruit2 = new Fruit(fruit);
            Console.WriteLine("{0}  {1}", fruit.i,fruit.fruit);
            Console.WriteLine("{0}  {1}", fruit2.i,fruit2.fruit);


        }
    }
}
