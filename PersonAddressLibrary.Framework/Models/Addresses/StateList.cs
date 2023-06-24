using System.Collections.Generic;

namespace PersonAddressLibrary.Framework.Models.Addresses
{
    static public class StateList
    {
        static public List<IAddressState> US_States => StateList.GetUSStates();

        public static List<IAddressState> GetUSStates()
        {

            List<IAddressState> usStates = new List<IAddressState>
            {
                new US_State { Abbreviation = "AL", Name =  "Alabama" },
                new US_State { Abbreviation = "AK", Name = "Alaska" },
                new US_State { Abbreviation = "AZ", Name = "Arizona" },
                new US_State { Abbreviation = "AR", Name = "Arkansas" },
                new US_State { Abbreviation = "CA", Name = "California" },
                new US_State { Abbreviation = "CO", Name = "Colorado" },
                new US_State { Abbreviation = "CT", Name = "Connecticut" },
                new US_State { Abbreviation = "DE", Name = "Delaware" },
                new US_State { Abbreviation = "DC", Name = "District Of Columbia" },
                new US_State { Abbreviation = "FL", Name = "Florida" },
                new US_State { Abbreviation = "GA", Name = "Georgia" },
                new US_State { Abbreviation = "HI", Name = "Hawaii" },
                new US_State { Abbreviation = "ID", Name = "Idaho" },
                new US_State { Abbreviation = "IL", Name = "Illinois" },
                new US_State { Abbreviation = "IN", Name = "Indiana" },
                new US_State { Abbreviation = "IA", Name = "Iowa" },
                new US_State { Abbreviation = "KS", Name = "Kansas" },
                new US_State { Abbreviation = "KY", Name = "Kentucky" },
                new US_State { Abbreviation = "LA", Name = "Louisiana" },
                new US_State { Abbreviation = "ME", Name = "Maine" },
                new US_State { Abbreviation = "MD", Name = "Maryland" },
                new US_State { Abbreviation = "MA", Name = "Massachusetts" },
                new US_State { Abbreviation = "MI", Name = "Michigan" },
                new US_State { Abbreviation = "MN", Name = "Minnesota" },
                new US_State { Abbreviation = "MS", Name = "Mississippi" },
                new US_State { Abbreviation = "MO", Name = "Missouri" },
                new US_State { Abbreviation = "MT", Name = "Montana" },
                new US_State { Abbreviation = "NE", Name = "Nebraska" },
                new US_State { Abbreviation = "NV", Name = "Nevada" },
                new US_State { Abbreviation = "NH", Name = "New Hampshire" },
                new US_State { Abbreviation = "NJ", Name = "New Jersey" },
                new US_State { Abbreviation = "NM", Name = "New Mexico" },
                new US_State { Abbreviation = "NY", Name = "New York" },
                new US_State { Abbreviation = "NC", Name = "North Carolina" },
                new US_State { Abbreviation = "ND", Name = "North Dakota" },
                new US_State { Abbreviation = "OH", Name = "Ohio" },
                new US_State { Abbreviation = "OK", Name = "Oklahoma" },
                new US_State { Abbreviation = "OR", Name = "Oregon" },
                new US_State { Abbreviation = "PA", Name = "Pennsylvania" },
                new US_State { Abbreviation = "RI", Name = "Rhode Island" },
                new US_State { Abbreviation = "SC", Name = "South Carolina" },
                new US_State { Abbreviation = "SD", Name = "South Dakota" },
                new US_State { Abbreviation = "TN", Name = "Tennessee" },
                new US_State { Abbreviation = "TX", Name = "Texas" },
                new US_State { Abbreviation = "UT", Name = "Utah" },
                new US_State { Abbreviation = "VT", Name = "Vermont" },
                new US_State { Abbreviation = "VA", Name = "Virginia" },
                new US_State { Abbreviation = "WA", Name = "Washington" },
                new US_State { Abbreviation = "WV", Name = "West Virginia" },
                new US_State { Abbreviation = "WI", Name = "Wisconsin" },
                new US_State { Abbreviation = "WY", Name = "Wyoming" },
            };



            return usStates;
        }



    }
}