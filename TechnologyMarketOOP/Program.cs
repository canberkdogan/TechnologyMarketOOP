using System;

namespace TechnologyMarketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'devam' is used to control the loop; it continues as long as 'true'
            bool devam = true;

            // Start of the main loop
            while (devam)
            {
                // Ask the user to choose between a Phone or a Computer
                Console.WriteLine("Phone for press 1, Computer for press 2:");
                string choose = Console.ReadLine();

                // Declare a variable of type BaseMachine to hold the product
                BaseMachine product;

                // If the user chooses '1', create a Phone object
                if (choose == "1")
                {
                    product = new Phone();
                    // Cast 'product' to Phone type to access Phone-specific properties
                    Phone telefon = (Phone)product;

                    // Get the Serial Number from the user
                    Console.Write("Serial Number: ");
                    telefon.SerialNum = int.Parse(Console.ReadLine());

                    // Get the Name from the user
                    Console.Write("Name: ");
                    telefon.Name = Console.ReadLine();

                    // Get the Explanation from the user
                    Console.Write("Explanation: ");
                    telefon.Explanation = Console.ReadLine();

                    // Get the Operating System from the user
                    Console.Write("Operating System: ");
                    telefon.OperatingSystem = Console.ReadLine();

                    // Ask if the phone has a TR license (Yes/No)
                    Console.Write("TR License? (Yes/No): ");
                    string trLicance = Console.ReadLine();
                    // Set TRLicance based on the user's input
                    telefon.TRLicance = trLicance.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                }
                // If the user chooses '2', create a Computer object
                else if (choose == "2")
                {
                    product = new Computer();
                    // Cast 'product' to Computer type to access Computer-specific properties
                    Computer bilgisayar = (Computer)product;

                    // Get the Serial Number from the user
                    Console.Write("Serial Number: ");
                    bilgisayar.SerialNum = int.Parse(Console.ReadLine());

                    // Get the Name from the user
                    Console.Write("Name: ");
                    bilgisayar.Name = Console.ReadLine();

                    // Get the Explanation from the user
                    Console.Write("Explanation: ");
                    bilgisayar.Explanation = Console.ReadLine();

                    // Get the Operating System from the user
                    Console.Write("Operating System: ");
                    bilgisayar.OperatingSystem = Console.ReadLine();

                    // Get the USB Port Count (2 or 4) from the user
                    Console.Write("USB Port Count (2 or 4): ");
                    bilgisayar.USBPortCount = int.Parse(Console.ReadLine());

                    // Ask if the computer has Bluetooth (Yes/No)
                    Console.Write("Bluetooth? (Yes/No): ");
                    string bluetoothVarMi = Console.ReadLine();
                    // Set Bluetooth property based on the user's input
                    bilgisayar.Bluetooth = bluetoothVarMi.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                }
                // If the user enters an invalid choice, show an error message
                else
                {
                    Console.WriteLine("Wrong choice. Please try again.");
                    continue; // Go back to the beginning of the loop
                }



            }
        }
    }
}