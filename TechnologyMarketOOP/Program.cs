using System;

namespace TechnologyMarketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("Phone for press 1, Computer for press 2:");
                string choose = Console.ReadLine();

                BaseMachine product;

                if (choose == "1")
                {
                    product = new Phone();
                    Phone telefon = (Phone)product;

                    Console.Write("Serial Number: ");
                    telefon.SerialNum = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    telefon.Name = Console.ReadLine();

                    Console.Write("Explanation: ");
                    telefon.Explanation = Console.ReadLine();

                    Console.Write("Operating System: ");
                    telefon.OperatingSystem = Console.ReadLine();

                    Console.Write("TR Licance? (Yes/No): ");
                    string trLicance = Console.ReadLine();
                    telefon.TRLicance = trLicance.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                }
                else if (choose == "2")
                {
                    product = new Computer();
                    Computer bilgisayar = (Computer)product;

                    Console.Write("Serial Number: ");
                    bilgisayar.SerialNum = int.Parse(Console.ReadLine());

                    Console.Write("Name: ");
                    bilgisayar.Name = Console.ReadLine();

                    Console.Write("Explanation: ");
                    bilgisayar.Explanation = Console.ReadLine();

                    Console.Write("Operating System: ");
                    bilgisayar.OperatingSystem = Console.ReadLine();

                    Console.Write("USB Port Count (2 or 4): ");
                    bilgisayar.USBPortCount = int.Parse(Console.ReadLine());

                    Console.Write("Bluetooth? (Yes/No): ");
                    string bluetoothVarMi = Console.ReadLine();
                    bilgisayar.Bluetooth = bluetoothVarMi.Equals("Yes", StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    Console.WriteLine("Wrong choice. Please try again.");
                    continue;
                }

                Console.WriteLine("Success");
                product.DisplayInfo();
                product.DisplayProductName();

                Console.Write("Another choice? (Yes/No): ");
                string answer = Console.ReadLine();

                if (!answer.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                {
                    devam = false;
                    Console.WriteLine("Have a good day!");
                }
            }
        }
    }
}
