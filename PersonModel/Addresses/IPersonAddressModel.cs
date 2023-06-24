namespace PersonAddressLibrary.Framework.Addresses
{
    public interface IPersonAddressModel
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string State { get; set; }
        string ZipCode { get; set; }

        internal AddressType.AddressTypes  AddressTypeSelected { get; set; }
        AddressType AddressType { get; set; }

    }
}
