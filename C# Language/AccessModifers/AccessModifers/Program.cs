using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifers
{

  public class Access
    {
        public int publicnumber;
        private int privatenumber;
        protected int protectednumber;
        internal int internalnumber;
        protected internal int number;

        public Access() {
            publicnumber = 1;
            privatenumber = 2;
            protectednumber = 3;
            internalnumber = 4;
            number = 5;
        }
    }


    public class Access2 {
        public void method2()
        {
            Access access = new Access();
            access.publicnumber = 1;
            access.internalnumber = 2;
            access.number = 3;

            // private and protected cannot be accessed

        }
    }


    public class Derived:Access
    {
        public void AccessProtectedMember()
        {
            // private cannot be accessed
            protectednumber = 10;
            publicnumber = 11;
            number = 12;
            internalnumber= 13;
        }
       
    }

}
