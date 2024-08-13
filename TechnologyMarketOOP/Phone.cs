using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyMarketOOP
{
    public class Phone : BaseMachine
    {
        public bool TRLicance {  get; set; }

        public override void DisplayProductName()
        {
            Console.WriteLine($"Phone Name: {Name}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            {
                Console.WriteLine("Your phone's licensed by Turkey");
            }
        }
    }
}
