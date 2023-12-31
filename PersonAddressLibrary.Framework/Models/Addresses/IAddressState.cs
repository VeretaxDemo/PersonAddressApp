﻿namespace PersonAddressLibrary.Framework.Models.Addresses
{
    public interface IAddressState
    {
        string Abbreviation { get; set; }
        string Name { get; set; }
        string GetName();
        string GetAbbreviation();
    }
}