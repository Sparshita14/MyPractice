using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Fruits
    {
        public string fname;
        public string fre2;

        public Fruits(string frs, string f2) {
            fname = frs;
            fre2 = f2;
        }

       public static void Main(string[] args) { 
            Fruits f=new Fruits("apple","pineapple");
            Console.WriteLine("fruits "+f.fname+"  "+ f.fre2);
            Console.ReadLine();
        }


    }
}
