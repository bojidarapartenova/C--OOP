namespace FootballTeamGenerator
{
    public class Player
    {
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("A name should not be empty.");
            }
            Name = name;
            Endurance = ValidateStats(endurance, "Endurance");
            Sprint = ValidateStats(sprint, "Sprint");
            Dribble = ValidateStats(dribble, "Dribble");
            Passing = ValidateStats(passing, "Passing");
            Shooting = ValidateStats(shooting, "Shooting");
        }

        public string Name { get; }
        public int Endurance { get; }
        public int Sprint { get; }
        public int Dribble { get; }
        public int Passing { get; }
        public int Shooting { get; }

        private static int ValidateStats(int value, string stat)
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentException($"{stat} should be between 0 and 100.");
            }

            return value;
        }

        public double SkillLevel => (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
    }
}
