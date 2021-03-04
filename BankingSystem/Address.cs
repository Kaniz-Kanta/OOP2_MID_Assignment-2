using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Address
    {

        private string houseNo;
        private string roadNo;
        private string city;
        private string country;

        public Address(string houseNo, string roadNo, string city, string country)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.city = city;
            this.country = country;
        }

        public string GetAddress()
        {
            return "Road No: " + this.roadNo + "\nHouse No: " + this.houseNo + "\nCity: " + this.city + "\nCountry: " + this.country;
        }
    }
}
