using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braennbollsturnering.Models
{
    public class Team
    {
        public Team(int id, string name, List<Player> players)
        {
            Id = id;
            Name = name;
            Players = players;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
    }
}
