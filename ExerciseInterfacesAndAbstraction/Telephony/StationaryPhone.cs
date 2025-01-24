using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public void Calling(string phoneNumber)
        {
            foreach(char c in phoneNumber)
            {
                if(char.IsLetter(c))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }

            Console.WriteLine($"Dialing... {phoneNumber}");
        }
    }
}
