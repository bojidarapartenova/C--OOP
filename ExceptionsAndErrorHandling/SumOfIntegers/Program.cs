using System.Xml.Linq;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string[] array = Console.ReadLine().Split();

            foreach(string str in array)
            {
                try
                {
                    sum += int.Parse(str);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{str}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{str}' is out of range!");
                }
                finally
                {
                    Console.WriteLine($"Element '{str}' processed - current sum: {sum}");
                }
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
