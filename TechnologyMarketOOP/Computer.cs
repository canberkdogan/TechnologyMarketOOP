using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyMarketOOP
{
    // The Computer class inherits from BaseMachine
    public class Computer : BaseMachine
    {
        // Property to check if the computer has Bluetooth or not
        public bool Bluetooth { get; set; }

        // Backing field for the USBPortCount property
        private int _usbPortCount;

        // Property to get or set the number of USB ports
        public int USBPortCount
        {
            get
            {
                // Return the current USB port count
                return _usbPortCount;
            }
            set
            {
                // Only allow USB port count of 2 or 4
                if (value == 2 || value == 4)
                {
                    _usbPortCount = value;
                }
                else
                {
                    // Show an error message if an invalid value is provided
                    Console.WriteLine("You chose the wrong USB port count.");
                    // Set the USB port count to -1 to indicate an error
                    USBPortCount = -1;
                }
            }
        }

        // Override method to display the name of the computer
        public override void DisplayProductName()
        {
            Console.WriteLine($"Computer Name: {Name}");
        }

        // Override method to display information about the computer
        public override void DisplayInfo()
        {
            // Call the base class's DisplayInfo method
            base.DisplayInfo();
            // Display Bluetooth connection status and USB port count
            Console.WriteLine($"Bluetooth Connection: {Bluetooth}\nUSB port count: {USBPortCount}");
        }
    }
}
