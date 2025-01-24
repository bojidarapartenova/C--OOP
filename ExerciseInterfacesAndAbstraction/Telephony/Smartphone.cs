using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseable
    {
        public void Browsing(string website)
        {
            foreach(char c in website)
            {
                if(char.IsDigit(c))
                {
                    Console.WriteLine("Invalid URL!");
                    return;
                }
            }

            Console.WriteLine($"Browsing: {website}!");
        }

        public void Calling(string phoneNumber)
        {
            foreach (char c in phoneNumber)
            {
                if (char.IsLetter(c))
                {
                    Console.WriteLine("Invalid number!");
                    return;
                }
            }

            Console.WriteLine($"Calling... {phoneNumber}");
        }
    }
}
