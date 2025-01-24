using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballTeamGenerator
{
    public class Team
    {
        private readonly Dictionary<string, Player> _players;

        public Team(string name)
        {
            if(string.IsNullOrEmpty(name)) throw new ArgumentNullException("A name should not be empty.");

            Name= name;
            _players=new Dictionary<string, Player>();
            Players = new ReadOnlyDictionary<string, Player>(_players);
        }
        public string Name { get; }
        public IReadOnlyDictionary<string, Player> Players { get; }

        public int Rating => CalculateRating();

        public void AddPlayer(Player player)
        {
            if(player is null) throw new ArgumentNullException(nameof(player));

            _players[player.Name] = player;
        }

        public bool RemovePlayer(string playerName)=> _players.Remove(playerName);

        private int CalculateRating()
        {
            if(Players.Count==0) return 0;

            return (int)Math.Round(_players.Values.Average(p => p.SkillLevel));
        }
    }
}
