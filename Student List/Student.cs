using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3a
{
    class Student : Person
    {
        int IdNumber;
        public Student(string firstName, string familyName, int idNumber) : base(firstName, familyName)
        {
            IdNumber = idNumber;
        }

        public override string ToString() => base.ToString() + " [" + IdNumber + "]";
        
    }
}
