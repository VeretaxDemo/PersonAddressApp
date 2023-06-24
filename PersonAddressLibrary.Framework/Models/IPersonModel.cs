using System.Collections.Generic;
using PersonAddressLibrary.Framework.Models.Addresses;

namespace PersonAddressLibrary.Framework.Models
{
    public interface IPersonModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        List<IPersonAddressModel> Addresses { get; set; }

        string DisplayPersonView { get; }
    }
}