﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {

        public Address Retreive(int addressID)
        {
            Address address = new Address(addressID);

            if (addressID == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.County = "Shire";
                address.Country = "Middle Earth";
                address.PostCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetreiveByCustomerID(int customerID)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot Row",
                City = "Hobbiton",
                County = "Shire",
                Country = "Middle Earth",
                PostCode = "144"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green Dragon",
                City = "Bywater",
                County = "Shire",
                Country = "Middle Earth",
                PostCode = "146"
            };

            addressList.Add(address);

            return addressList;
        }
        public bool Save(Address address)
        {
            return true;
        }
    }
}
