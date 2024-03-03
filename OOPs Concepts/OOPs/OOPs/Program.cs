using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    // class creation
    public class Name
    {
        public string nam; // field
        public string myname(string names = "sparsh") // method
        {
            return names;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // creating object
            Name n = new Name();

            // accessing field
            n.nam = "hello";

            // calling method of class

            string nm = n.myname();

            string nm2 = n.myname("rani");
            Console.WriteLine("the value from method in class is " + nm);
            Console.WriteLine("the value from method in class is " + nm2);
            Console.ReadLine();
        }
    }
}
