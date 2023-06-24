using System.Collections.Generic;

namespace PersonAddressLibrary.Framework
{
    public class PersonModel
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<PersonAddressModel> Addresses { get; set; } = new List<PersonAddressModel>();
    }
}
