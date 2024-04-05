using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delgates
{
    // Delegate declaration
   
    internal class Program
    {
        public delegate void myadd(int a, int b);

        void methodadd(int a, int b)
        {
            Console.WriteLine("added val={0} ", a+b);
        }

        void methodsub(int a, int b)
        {
            Console.WriteLine("sub val={0} ", a - b);
        }
        static void Main(string[] args)
        {
           Program program= new Program();
            myadd ad = new myadd(program.methodadd);
            ad(23, 78);
            ad += program.methodsub;
            ad(23, 10);
            ad-=program.methodadd;
            ad(11, 11);


        }
    }
}
