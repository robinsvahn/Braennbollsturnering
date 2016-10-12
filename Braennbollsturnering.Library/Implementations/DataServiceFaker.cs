using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Braennbollsturnering.Library.Interfaces;
using Braennbollsturnering.Models;

namespace Braennbollsturnering.Library.Implementations
{
    public class DataServiceFaker : IDataService
    {
        public IEnumerable<Team> GetTeams()
        {
            List<Player> TeamEnghagen = new List<Player>
            {
                new Player(1, "Adam"),
                new Player(2, "Markus"),
                new Player(3, "Maite"),
                new Player(4, "Gaetan"),
                new Player(5, "Erik"),
                new Player(6, "Jonathan"),
                new Player(7, "Valle"),
                new Player(9, "Sofia"),
                new Player(10, "Karl-Peter")
            };

            List<Player> TeamRik = new List<Player>
            {
                new Player(1, "Philip"),
                new Player(2, "Frey"),
                new Player(3, "Jonathan"),
                new Player(4, "Markus"),
                new Player(5, "Tobbe"),
                new Player(6, "Vide"),
                new Player(7, "Christian"),
                new Player(8, "Emilia"),
                new Player(9, "Sara")
            };

            List<Team> teams = new List<Team>
            {
                new Team(1, "Team Enghagen", TeamEnghagen),
                new Team(2, "Team RIK", TeamRik)
            };

            return teams;
        }
    }
}
