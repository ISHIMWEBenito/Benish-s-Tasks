using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Michal";
            //person.FamilyName = "Antkowiak";
            //person.SetData("Michal", "Antkowiak", "Qwerty", "32", "16",
            //                "12345", "Poznan", "Poland");
            //Console.WriteLine(person.IntroduceYourself());

            Console.Write("How many persons? ");
            int n = int.Parse(Console.ReadLine());
            Person[] person = new Person[n];
            List<Person> personList = new List<Person>();
            for(int i=1; i <= n; i++)
            {
                Console.WriteLine("Person " + i + ":");
                Console.Write("First Name: ");
                string firstName = Console.ReadLine();
                Console.Write("Family Name: ");
                string familyName = Console.ReadLine();
                Console.Write("Street: ");
                string street = Console.ReadLine();
                Console.Write("House number: ");
                string house = Console.ReadLine();
                Console.Write("Apartment number: ");
                string apartment = Console.ReadLine();
                Console.Write("Post code: ");
                string pc = Console.ReadLine();
                Console.Write("City: ");
                string city = Console.ReadLine();
                Console.Write("Country: ");
                string country = Console.ReadLine();
                person[i - 1] = new Person();
                person[i - 1].SetData(firstName, familyName, street, house,
                                    apartment, pc, city, country);
                personList.Add(new Person());
                personList.Last().SetData(firstName, familyName, street, house,
                                    apartment, pc, city, country);
            }

            while (true)
            {
                Console.Clear();
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i + ". " + person[i - 1].FirstName + " " +
                                    person[i - 1].FamilyName);
                }
                Console.Write("Enter number to display address: ");
                int x = int.Parse(Console.ReadLine());
                if (x <= n && x > 0)
                {
                    Console.WriteLine(person[x - 1].IntroduceYourself());
                    Console.WriteLine(personList[x - 1].IntroduceYourself());
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong number");
                    Console.ReadLine();
                }
            }
        }
    }
}
