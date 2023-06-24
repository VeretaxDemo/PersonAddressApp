# PersonAddressApp
Examples of WinForm app transformed to WPF
This project is a simple example.

1. A WinForms Project developed as practice while going through C# Master Course 'WinForms' Section
  - Deviates from shown example in several ways
  - as an overall dashboard window for viewing all of the People added
  - has an AddressType dropdown which could be : Home, Shipping, or Work
  - The AddressType contains an AddressType enumeration (to indicate which subclass to use for Home, Shipping, or Work Address)
  - AddressType itself started off as an Abstract Class, later was moved to an Interface implemented by an Address class to simplify
  - State is a Dropdownlist instead (A bit tricky since the ID we use is the Abbreviation instead of a Number.   
2. a .NetFramework library which, as it happens implements a lot of the logic outside of the forms itself.
3. Later, during the same course, I decided to create a WPF .Net Core project and migrate the UI to this.
  - 
