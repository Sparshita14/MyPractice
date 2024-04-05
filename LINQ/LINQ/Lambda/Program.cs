using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3 };
            // lambda expression
            var res = ints.Select(i => i * i);
         foreach (var i in res)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");

            var res2 = ints.Select(i => i * i).Where(i => i % 2 == 0);
            foreach (var i in res2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");
            // func 
            Func<double, double> f2 = x => x * x;
           
            Console.WriteLine(f2(12));
        }
    }
}
