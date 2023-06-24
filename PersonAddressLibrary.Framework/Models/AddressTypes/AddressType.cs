namespace PersonAddressLibrary.Framework.Models.AddressTypes
{
    public abstract class AddressType : IAddressType
    {
        public enum AddressTypes
        {
            Home = 1,
            Shipping = 2,
            Work = 3
        }

        public int Number { get; set; }
        public string Name { get; set; }

        public int GetAddressTypeNumber()
        {
            return this.Number;
        }

        public string GetAddressTypeName()
        {
            return this.Name;
        }
    }
}
