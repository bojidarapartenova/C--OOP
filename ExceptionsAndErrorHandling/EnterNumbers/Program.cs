namespace EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            List<int>numbers = new List<int>();

            while (numbers.Count<10)
            {
                try
                {
                    int currentNumber=ReadNumber(start, end);
                    start = currentNumber;
                    numbers.Add(currentNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
        public static int ReadNumber(int start, int end)
        {
            int n = int.Parse(Console.ReadLine());

            if (n <= start || n >= end)
                throw new ArgumentException($"Your number is not in range {start} - 100!");
            return n;
        }
    }
}