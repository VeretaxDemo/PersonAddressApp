namespace PersonAddressLibrary.Framework.AddressTypes
{
    public abstract class AddressType
    {
        public enum AddressTypes
        {
            Home = 1,
            Shipping = 2,
            Work = 3
        }

        public int Number { get; set; }
        public string Name { get; set; }
    }
}
