using PersonAddressLibrary.Framework.Models.AddressTypes;

namespace PersonAddressLibrary.Framework.Models.Addresses
{
    public interface IPersonAddressModel
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        IAddressState State { get; set; }
        string ZipCode { get; set; }

        AddressType.AddressTypes  AddressTypeSelected { get; set; }
        AddressType AddressType { get; set; }
        string FullAddress { get; }
        string GetFullAddressString();
        void SelectAddressType(AddressType.AddressTypes addressType);
        AddressType.AddressTypes GetAddressTypeSelected(AddressType.AddressTypes addressType);
    }
}
