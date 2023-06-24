using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonAddressLibrary.Framework.Addresses;

namespace PersonAddressLibrary.Framework
{
    public static class ModelMessages
    {
        public static string GetPersonFullName(this PersonModel person)
        {
            var message = $"{person.FirstName} {person.LastName}";
            return message;
        }

        public static string GetFulLAddress(this PersonAddressModel address)
        {
            string addressType = address.AddressType.Name;
            
            if (string.IsNullOrWhiteSpace(address.Address2))
            {
                return $"({addressType}) { address.Address1 }, { address.City }, { address.State } { address.ZipCode }";
            }
            else
            {
                return $"({addressType}) { address.Address1 }, { address.Address2 } , {address.City}, {address.State} {address.ZipCode}";
            }
        }
    }
}
