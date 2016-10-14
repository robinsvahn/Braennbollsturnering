using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Braennbollsturnering.Library.Interfaces;
using Braennbollsturnering.Models;

namespace Braennbollsturnering.Library
{
    public class DataService : IDataService
    {  
        public IEnumerable<Team> GetTeams()
        {
            throw new NotImplementedException();
        }

        public Team GetTeamWithID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
