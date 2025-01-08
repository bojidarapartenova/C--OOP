namespace PizzaCalories
{
    public class Pizza
    {
        private readonly List<Topping> _toppings;

        public Pizza(string name, Dough dough)
        {
            if(string.IsNullOrEmpty(name) || name.Length>15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            Name = name;
            Dough = dough;
            _toppings = new List<Topping>();
            Toppings = _toppings.AsReadOnly();
        }
        public string Name { get; }
        public Dough Dough { get; }
        public IReadOnlyCollection<Topping> Toppings { get; }

        public double Calories => Dough.Calories + Toppings.Sum(p => p.Calories);

        public void AddTopping(Topping topping)
        {
            if(topping is null) throw new ArgumentNullException(nameof(topping));

            if(Toppings.Count==10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            _toppings.Add(topping);
        }
    }
}
