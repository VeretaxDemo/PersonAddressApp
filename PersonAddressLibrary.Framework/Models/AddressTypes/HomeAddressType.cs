namespace PersonAddressLibrary.Framework.Models.AddressTypes
{
    public class HomeAddressType : AddressType 
    {
        public HomeAddressType()
        {
            Name = "Home";
            Number = (int)AddressTypes.Home;
        }
    }
}
