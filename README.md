# TechnologyMarketOOP


Overview
This application is designed to manage and register products in a technology store, specifically focusing on Phones and Computers. The program allows users to create instances of these products, enter their details, and display the information. The system utilizes Object-Oriented Programming (OOP) principles such as inheritance, encapsulation, polymorphism, and abstraction to achieve this.

Key Concepts
1. Base Class (BaseMakine)
BaseMakine is the base class for both Telefon and Bilgisayar.
Common properties such as ProductionDate, SerialNumber, Name, Description, and OperatingSystem are defined here.
A method BilgileriYazdir() is provided to print these common details.
2. Derived Classes (Telefon and Bilgisayar)
Telefon and Bilgisayar inherit from BaseMakine.
Telefon has additional properties: OperatingSystem and IsTrLicensed.
Bilgisayar has additional properties: UsbPortCount and HasBluetooth.
3. Encapsulation
For the Bilgisayar class, the UsbPortCount property can only be set to 2 or 4. Any other value will trigger a warning message and set the value to -1.
4. Automatic Production Date
The ProductionDate is automatically set to the current date and time when a new object is instantiated.
5. Polymorphism
The BilgileriYazdir() method in BaseMakine is overridden in the Telefon and Bilgisayar classes to include class-specific details when printing the product information.
6. Abstraction
An abstract method UrunAdiGetir() is defined in BaseMakine, which is overridden in the Telefon and Bilgisayar classes to display:
"Your phone’s name ---> ......"
"Your computer’s name ---> ......"
Program Flow
User Input for Product Type:

The program prompts the user to press 1 to produce a phone or 2 to produce a computer.
Object Creation:

Based on the user’s selection, the program creates an instance of either Telefon or Bilgisayar and prompts the user to enter the product details.
Product Creation Confirmation:

After the user enters all the required details, the program confirms that the product has been successfully created.
Repeat or Exit:

The user is asked if they want to create another product. If they answer "yes," the program returns to step 1. If they answer "no," the program ends with a "Good day!" message.
How to Run
Compile the program using a C# compiler.
Run the executable from the command line.
Follow the prompts to create and register products in the store.
