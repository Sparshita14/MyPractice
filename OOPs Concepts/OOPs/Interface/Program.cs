using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{

    public interface IFruits
    {
        void nameof();

        void colorof();
        
    }

    public interface IVeg
    {
        void whichveg(int val);

    }

    public class Apple:IFruits, IVeg { 
        
       public void nameof()
        {
            Console.WriteLine("this is fruits interface");
        }

        public void colorof()
        {
            Console.WriteLine("this is second method of interface");
        }
        // need to implement all the method from the interface class

        public void whichveg(int val)
        {
            Console.WriteLine("its");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            IFruits fruits = new Apple(); // creating fruits object from apple we cannot create obj from interface
            fruits.colorof();
            fruits.nameof();
        }
    }
}
