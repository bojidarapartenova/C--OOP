using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            while (animal != "Beast!")
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);
                string gender = input[2];

                try
                {

                    switch (animal)
                    {
                        case "Dog":
                            {
                                Dog dog = new Dog(name, age, gender);
                                Console.WriteLine(dog);
                            }
                            break;

                        case "Cat":
                            {
                                Cat cat = new Cat(name, age, gender);
                                Console.WriteLine(cat);
                            }
                            break;

                        case "Frog":
                            {
                                Frog frog = new Frog(name, age, gender);
                                Console.WriteLine(frog);
                            }
                            break;

                        case "Kitten":
                            {
                                Kitten kitten = new Kitten(name, age);
                                Console.WriteLine(kitten);
                            }
                            break;

                        case "Tomcat":
                            {
                                Tomcat tomcat = new Tomcat(name, age);
                                Console.WriteLine(tomcat);
                            }
                            break;
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                animal = Console.ReadLine();
            }
        }
    }
}
