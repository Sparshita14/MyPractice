using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Multiple
{
     interface Iparent1
    {
         int m1();
    }
    

     interface Iparent2
    {
        int m1();
    }
    

   

    public class child: Iparent1, Iparent2
    {
     
        public int m1()
        {
            return 1;
        } 

        int Iparent2.m1()
        {

            return 2;
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Iparent1 p1= new child();
            int n=p1.m1();
            Console.WriteLine(n);
        }
    }
}
