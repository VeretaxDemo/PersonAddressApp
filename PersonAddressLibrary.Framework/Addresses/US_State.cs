namespace PersonAddressLibrary.Framework.Addresses
{
    public class US_State : IAddressState
    {
        public string Abbreviation { get; set; }
        public string Name { get; set; }

        public string GetName()
        {
            return this.GetName();
        }

        public string GetAbbreviation()
        {
            return this.Abbreviation;
        }
    }
}