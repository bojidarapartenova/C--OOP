namespace PizzaCalories
{
    public class Topping
    {
        private readonly Dictionary<string, double> _typeOfToppingModifiers = new Dictionary<string, double>(StringComparer.InvariantCultureIgnoreCase)
        {
            ["Meat"] = 1.2,
            ["Veggies"] = 0.8,
            ["Cheese"] = 1.1,
            ["Sauce"] = 0.9,
        };

        public Topping(string typeOfTopping, double weight)
        {
            if(!_typeOfToppingModifiers.ContainsKey(typeOfTopping))
            {
                throw new ArgumentException($"Cannot place {typeOfTopping} on top of your pizza.");
            }
            if(weight<1 || weight>50)
            {
                throw new ArgumentException($"{typeOfTopping} weight should be in the range [1..50].");
            }

            TypeOfTopping = typeOfTopping;
            Weight = weight;
        }

        public string TypeOfTopping { get; }
        public double Weight { get; }

        public double Calories => 2 * Weight * _typeOfToppingModifiers[TypeOfTopping];
    }
}
