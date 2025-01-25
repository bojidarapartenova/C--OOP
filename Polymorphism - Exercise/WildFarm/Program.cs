namespace WildFarm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalData = input.Split();
                string type = animalData[0];
                string name = animalData[1];
                double weight = double.Parse(animalData[2]);
                string livingRegion;
                string breed;
                double wingSize;
                Animal animal;

                string[] foodData = Console.ReadLine().Split();
                string foodType = foodData[0];
                int quantity = int.Parse(foodData[1]);
                Food food = null;

                if (foodType == "Vegetable") food = new Vegetable(quantity);
                else if (foodType == "Fruit") food = new Fruit(quantity);
                else if (foodType == "Meat") food = new Meat(quantity);
                else if (foodType == "Seeds") food = new Seeds(quantity);


                if (type == "Owl")
                {
                    wingSize = double.Parse(animalData[3]);
                    animal = new Owl(name, weight, wingSize);
                    animal.ProduceSound();

                    if (animal.IsEating(foodType))
                    {
                        animal.Weight += 0.25 * food.Quantity;
                        animal.FoodEaten += food.Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }

                    animals.Add(animal);
                }
                else if (type == "Hen")
                {
                    wingSize = double.Parse(animalData[3]);
                    animal = new Hen(name, weight, wingSize);
                    animal.ProduceSound();

                    animal.Weight += 0.35 * food.Quantity;
                    animal.FoodEaten += food.Quantity;

                    animals.Add(animal);
                }
                else if (type == "Mouse")
                {
                    livingRegion = animalData[3];
                    animal = new Mouse(name, weight, livingRegion);
                    animal.ProduceSound();

                    if (animal.IsEating(foodType))
                    {
                        animal.Weight += 0.10 * food.Quantity;
                        animal.FoodEaten += food.Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }

                    animals.Add(animal);
                }
                else if(type=="Dog")
                {
                    livingRegion = animalData[3];
                    animal = new Dog(name, weight, livingRegion);
                    animal.ProduceSound();

                    if (animal.IsEating(foodType))
                    {
                        animal.Weight += 0.40 * food.Quantity;
                        animal.FoodEaten += food.Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }

                    animals.Add(animal);
                }
                else if(type =="Cat")
                {
                    livingRegion = animalData[3];
                    breed = animalData[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                    animal.ProduceSound();

                    if (animal.IsEating(foodType))
                    {
                        animal.Weight += 0.30 * food.Quantity;
                        animal.FoodEaten += food.Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }

                    animals.Add(animal);
                }
                else if(type=="Tiger")
                {
                    livingRegion = animalData[3];
                    breed = animalData[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                    animal.ProduceSound();

                    if (animal.IsEating(foodType))
                    {
                        animal.Weight += 1.00 * food.Quantity;
                        animal.FoodEaten += food.Quantity;
                    }
                    else
                    {
                        Console.WriteLine($"{type} does not eat {foodType}!");
                    }

                    animals.Add(animal);
                }
            }

            foreach(var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}