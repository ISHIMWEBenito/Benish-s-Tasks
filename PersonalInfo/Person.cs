using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        /*private string firstName;
        private string familyName;

        public string FirstName
        {
            private set { firstName = value; }
            get { return firstName; }
        }
        public string FamilyName
        {
            private set { familyName = value; }
            get { return familyName; }
        }*/
        PostalAddress Address = new PostalAddress();
        public string FirstName { get; private set; }
        public string FamilyName { get; private set; }
        public string IntroduceYourself()
        {
            return "My name is " + this.FirstName
                   + " " + this.FamilyName
                   + "\nMy address:\n" + Address.AddressInPostalFormat;
        }
        public void SetData(string firstName, string familyName, string streetName, string houseNumber,
                            string apartmentNumber, string postCode,
                            string city, string country)
        {
            this.FirstName = firstName;
            this.FamilyName = familyName;
            Address.SetData(streetName, houseNumber,
                            apartmentNumber, postCode,
                            city, country);
        }
    }
}
