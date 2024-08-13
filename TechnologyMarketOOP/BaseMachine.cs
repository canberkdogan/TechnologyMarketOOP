using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnologyMarketOOP
{
   public abstract class BaseMachine
    {
        public DateTime ProductDate { get; set; }
        public int SerialNum{  get; set; }
        public string Name { get; set; }
        public string Explanation{  get; set; }
        public string OperatingSystem {  get; set; }

        public BaseMachine() 
        {
            SetProductDate();
       
        }

        public void SetProductDate()
        {
            ProductDate = DateTime.Now;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($" Product Name {Name}\n Product Serial Number {SerialNum}\n Product Explanation {Explanation}\n Operating System {OperatingSystem}\n Product Date{ProductDate}\n");
        }

        public abstract void DisplayProductName();
    }
}
