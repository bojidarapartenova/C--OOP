namespace Raiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BaseHero> heroes = new List<BaseHero>();

            int n=int.Parse(Console.ReadLine());
            while(heroes.Count!=n)
            {
                string heroName=Console.ReadLine();
                string heroType=Console.ReadLine();

                if(heroType=="Druid")
                {
                    BaseHero druid = new Druid(heroName, 80);
                    heroes.Add(druid);
                }
                else if(heroType=="Paladin")
                {
                    BaseHero paladin = new Paladin(heroName, 100);
                    heroes.Add(paladin);
                }
                else if(heroType=="Rogue")
                {
                    BaseHero rogue=new Rogue(heroName, 80);    
                    heroes.Add(rogue);
                }
                else if(heroType=="Warrior")
                {
                    BaseHero warrior=new Warrior(heroName, 100);
                    heroes.Add(warrior);
                }
                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach(var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
            }

            int powerSum = heroes.Sum(x => x.Power);
            if(powerSum>=bossPower)
            {
                Console.WriteLine("Victory!");
            }
            else
            {
                Console.WriteLine("Defeat...");
            }
        }
    }
}