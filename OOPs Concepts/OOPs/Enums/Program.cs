using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    enum Fruits
    {
        Apple,
        Orange,
        Banana
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
           Fruits fruits = Fruits.Apple;
            Console.WriteLine(fruits.ToString());
            
        }
    }
}
