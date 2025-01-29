namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;

            while (count < 3)
            {
                string[] commandData = Console.ReadLine().Split();
                string command = commandData[0];

                try
                {
                    switch (command)
                    {
                        case "Replace":
                            int index = int.Parse(commandData[1]);

                            if (index < 0 || index >= list.Count)
                            {
                                throw new ArgumentException("The index does not exist!");
                            }

                            int element = int.Parse(commandData[2]);

                            list.RemoveAt(index);
                            list.Insert(index, element);
                            break;

                        case "Print":
                            int startIndex = int.Parse(commandData[1]);

                            if (startIndex < 0 || startIndex >= list.Count)
                            {
                                throw new ArgumentException("The index does not exist!");
                            }

                            int endIndex = int.Parse(commandData[2]);

                            if (endIndex < 0 || endIndex >= list.Count)
                            {
                                throw new ArgumentException("The index does not exist!");
                            }


                            for (int i = startIndex; i < endIndex; i++)
                            {
                                Console.Write(list[i] + ", ");
                            }
                            Console.Write(list[endIndex]);
                            Console.WriteLine();
                            break;

                        case "Show":
                            int indexToShow = int.Parse(commandData[1]);

                            if (indexToShow < 0 || indexToShow >= list.Count)
                            {
                                throw new ArgumentException("The index does not exist!");
                            }

                            Console.WriteLine(list[indexToShow]);
                            break;
                    }
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                    count++;
                }
                catch(FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    count++;
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}