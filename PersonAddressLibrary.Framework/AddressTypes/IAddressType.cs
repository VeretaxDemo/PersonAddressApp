namespace PersonAddressLibrary.Framework.AddressTypes
{
    public interface IAddressType
    {
        int Number { get; set; }
        string Name { get; set; }
        int GetAddressTypeNumber();
        string GetAddressTypeName();
    }
}