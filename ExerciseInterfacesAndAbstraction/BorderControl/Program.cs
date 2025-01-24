using System.Security.Cryptography.X509Certificates;

namespace BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<IBuyer> people = new List<IBuyer>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 4)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string id = data[2];
                    string birthdate = data[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    people.Add(citizen);
                }
                else if (data.Length == 3)
                {
                    string name = data[0];
                    int age = int.Parse(data[1]);
                    string group = data[2];

                    Rebel rebel = new Rebel(name, age, group);
                    people.Add(rebel);
                }
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                foreach(var person in people)
                {
                    if(person.Name== command)
                    {
                        person.BuyFood();
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(people.Sum(x=>x.Food));
        }
    }
}