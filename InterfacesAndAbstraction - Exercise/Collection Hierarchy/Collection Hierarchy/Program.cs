namespace CollectionHierarchy
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] items = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());

            AddCollection firstLine = new();
            foreach (string item in items)
            {
                Console.Write($"{firstLine.Add(item)} ");
            }

            Console.WriteLine();

            AddRemoveCollection secondLine = new();
            foreach (string item in items)
            {
                Console.Write($"{secondLine.Add(item)} ");
            }

            Console.WriteLine();

            MyList thirdLine = new();
            foreach (string item in items)
            {
                Console.Write($"{thirdLine.Add(item)} ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{secondLine.Remove()} ");
            }

            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{thirdLine.Remove()} ");
            }

            Console.WriteLine();
        }
    }
}