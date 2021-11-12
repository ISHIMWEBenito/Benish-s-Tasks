using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class PostalAddress
    {
        public string StreetName { get; private set; }
        public string HouseNumber { get; private set; }
        public string ApartmentNumber { get; private set; }
        public string PostCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string AddressInPostalFormat
        {
            get
            {
                return HouseNumber + "/" + ApartmentNumber + " "
                    + StreetName + "\n" + City + "\n" + PostCode
                    + "\n" + Country;
            }
        }
        public void SetData(string streetName, string houseNumber,
                            string apartmentNumber, string postCode,
                            string city, string country)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
            ApartmentNumber = apartmentNumber;
            PostCode = postCode;
            City = city;
            Country = country;
        }
    }
}
