using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Prop
{
    public class Fruits
    {

        
        private string frname; // field 
        public string FruitName // property
        {
            get { return frname; }
            set { frname = value; }
        }

        // automatic property
        public string fname { get; set; }

        public static void Main(string[] args)
        {
            Fruits f = new Fruits();

            f.frname = "orange";

            f.fname = "apple";

            Console.WriteLine(f.frname);

            Console.WriteLine(f.fname);
            Console.ReadLine();
        }
    }
}
