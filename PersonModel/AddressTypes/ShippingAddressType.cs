namespace PersonAddressLibrary.Framework.AddressTypes
{
    public class ShippingAddressType : AddressType
    {
        public ShippingAddressType()
        {
            Name = "Shipping";
            Number = (int)AddressTypes.Shipping;
        }
    }
}
