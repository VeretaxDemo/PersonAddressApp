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
	- Some logic that was in the WinForm Events was migrated to the .NetFramework library (some parts for example those that were passing the comobox or listbox control, turned out to not be usable, because they exist in different namespaces in WinForms and WpF
	- Binding for the ListBox for Addresses and People required adding some additional methods to interfaces to Get FullAddress, and in the case of the People ListBox, a Stack Panel that bound three Textboxes to the following:
		- LastName Property
		- ", " hard coded text
		- FirstName Property
		- Note this is not sorted in either application at present
	4. Known Enhancements by View/Window
		- Address ListBox does not have an 'edit' function
		- Address ListBox does not have a property to mark 'current'
		- Address ListBox does not have a date created or date modified property
		- Person ListBox does not have an 'edit' function
		- Person ListBox does not have a property to mark 'isactive'
		- Person ListBox does not have a date created or date modified property
		- Does not currently have the ability to save all people with their addresses
			- to CSV
			- to JSON
			- to DB through API
			- to DB through Repository
		- The Data does not have an option to load from a previously created
			- from CSV
			- from JSON
			- from DB through API
			- from DB through Repository
		- PersonModel does not have a unique Identifier (right now it relies upon the list index selected, which could be different if sorting was used)
		- AddressModel does not have a unique Identifier (right now it relies upon the list index selected, which could be different if sorting was used)

	
