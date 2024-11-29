using System;

namespace Restaurant
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string product = Console.ReadLine();
            
            switch(product)
            {
                case "Coffee":
                    {
                        string name = Console.ReadLine();
                        double caffeine=double.Parse(Console.ReadLine());

                        Coffee coffee=new Coffee(name, caffeine);

                        Console.WriteLine(coffee);
                    }
                    break;
            }
        }
    }
}