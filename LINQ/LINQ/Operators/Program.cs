using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stream { get; set; }

        public Student(int id, string name, string stream) { 
            this.Id = id;
            this.Name = name;
            this.Stream = stream;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, "Name1", "IT");
            Student s2 = new Student(13, "Name2", "CSE");
            Student s3 = new Student(14, "Name3", "IT");
            Student s4 = new Student(15, "Name4", "CSE");
            Student s5 = new Student(16, "Name5", "CSE");

            List<Student> list = new List<Student>();

            List<Student> list2 = new List<Student>
            {
                new Student(12,"name","i2"),
                new Student(13,"name","122")
        };
            list.Add(s1);
            list.Add(s2);
            list.Add(s3);
            list.Add(s4);
            list.Add(s5);


            // ordering opertators

            // order by

            var orderby = from s in list
                          orderby s.Stream
                          select (s.Name, s.Id, s.Stream);

            foreach (var student in orderby)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Stream: {student.Stream}");
            }

            Console.WriteLine("---------------");

            // OrderByDescending

            var orderbydec= from s in list
                            orderby s.Id descending
                            select s;
            foreach (var student in orderbydec)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Stream: {student.Stream}");
            }
            Console.WriteLine("---------------");

            // thenby

            var orderthenby =list.OrderBy(s => s.Stream).ThenBy(s => s.Id);
            foreach (var student in orderthenby)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Stream: {student.Stream}");
            }

            Console.WriteLine("---------------");
            // group by

            var groupby = from p in list
                          group p by p.Stream;

           foreach(var student in groupby)
            {
                Console.WriteLine(student.Key);

                foreach (Student student2 in student)
                {
                    Console.WriteLine(student2.Name);
                }
            }
            Console.WriteLine("---------------");

            // join operator

            // common
            IList<string> strList1 = new List<string>() {"One","Two","Three","Four"};

            IList<string> strList2 = new List<string>() {"One","Two","Five","Six"};

            var innerJoin = strList1.Concat(strList2);

            foreach(var i in innerJoin)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("---------------");

        }
    }
}
