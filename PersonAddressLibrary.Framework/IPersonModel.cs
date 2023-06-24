using System.Collections.Generic;
using PersonAddressLibrary.Framework.Addresses;

namespace PersonAddressLibrary.Framework
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