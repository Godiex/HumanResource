using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Location
    {
        public int Id { private set; get; }
        public string StreetAddress { private set; get;} = string.Empty;
        public string PostalCode { private set; get; } = string.Empty;
        public string City { private set; get; } = string.Empty;
        public string StateProvince { private set; get; } = string.Empty;
        public Country Country { private set; get; }

        public Location(int id, string streetAddress, string postalCode, string city, string stateProvince)
        {
            Id = id;
            StreetAddress = street_address;
            PostalCode = postal_code;
            City = city;
            StateProvince = state_province;
        }
    }
}
