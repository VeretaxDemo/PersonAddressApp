namespace PersonAddressLibrary.Framework.Models.AddressTypes
{
    public  class WorkAddressType : AddressType
    {
        public WorkAddressType()
        {
            Name = "Work";
            Number = (int)AddressTypes.Work;
        }
    }
}
