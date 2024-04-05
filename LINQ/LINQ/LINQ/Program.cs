using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] language = {"C#", "VB", "Java", "C++","C", "Perl", "Ruby", "Python"};

            // query syntax
            var result = from lang in language
                        where lang.Contains('C')
                         select lang;
            foreach(var i in  result)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();

            // method syntax or fluent syntax
            var method = language.Where(lang => lang.Contains('C'));
            foreach (var i in method)
            {
                Console.WriteLine(i);
            }

            var me = language.Count();
            Console.WriteLine(me);

            var qo = from n in language
                     where n.Contains('n')
                     select n;

            Console.WriteLine(qo.Count());


            var p =language.OrderBy(lang => lang);

            foreach(var i in p)
            {
                Console.WriteLine("order==>"+i);
            }


        }
    }
}
