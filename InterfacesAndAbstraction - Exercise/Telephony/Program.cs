namespace Telephony
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] websites = Console.ReadLine().Split();

            foreach (string number in numbers)
            {
                if (number.Length == 10)
                {
                    ICallable smartphone = new Smartphone();
                    smartphone.Calling(number);
                }
                else if(number.Length == 7)
                {
                    ICallable stationatyPhone = new StationaryPhone();
                    stationatyPhone.Calling(number);
                }
            }

            foreach(string website in websites)
            {
                IBrowseable smartphone = new Smartphone();
                smartphone.Browsing(website);
            }
        }
    }
}