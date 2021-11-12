using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3a
{
    class Person
    {
        private string FirstName, FamilyName;
        public Person(string firstName, string familyName)
        {
            FirstName = firstName;
            FamilyName = familyName;
        }
        public override string ToString() =>  FirstName + " " + FamilyName;
    }
}
