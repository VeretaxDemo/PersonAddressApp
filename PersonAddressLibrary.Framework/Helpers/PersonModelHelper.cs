using System.Collections.Generic;
using System.Windows.Forms;
using PersonAddressLibrary.Framework.Addresses;
using PersonAddressLibrary.Framework.AddressTypes;

namespace PersonAddressLibrary.Framework.Helpers
{
    public static class PersonModelHelper
    {
        public static IPersonAddressModel PrepareAddressData(int addressType, string address1, string address2, string city, IAddressState selectedState, string zipCode)
        {
            switch (addressType)
            {
                case 1:
                    HomePersonAddressModel homeAddress = new HomePersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState,
                    };

                    homeAddress.SelectAddressType(AddressType.AddressTypes.Home);

                    return homeAddress;

                    break;
                case 2:
                    ShippingPersonAddressModel shippingAddress = new ShippingPersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    shippingAddress.SelectAddressType(AddressType.AddressTypes.Shipping);

                    return shippingAddress;
                    break;
                case 3:
                    WorkPersonAddressModel workAddress = new WorkPersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    workAddress.SelectAddressType(AddressType.AddressTypes.Work);

                    return workAddress;
                    break;
                default:
                    HomePersonAddressModel homePersonAddress = new HomePersonAddressModel()
                    {
                        Address1 = address1,
                        Address2 = address2,
                        City = city,
                        ZipCode = zipCode,
                        State = selectedState
                    };

                    return homePersonAddress;
                    break;
            }
        }
    }
}