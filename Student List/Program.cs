using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3a
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Person", "Person");
            Person p2 = new Student("Person", "Student", 123);
            Student s1 = new Student("Student", "Student", 124);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(s1);

            Person[] person = new Person[] {p1, p2, s1};
            for (int i = 0; i < person.Length; i++)
                Console.WriteLine(person[i]);
        }
    }
}
