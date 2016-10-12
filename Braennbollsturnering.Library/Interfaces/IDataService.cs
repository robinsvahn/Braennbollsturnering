using Braennbollsturnering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braennbollsturnering.Library.Interfaces
{
    public interface IDataService
    {
        IEnumerable<Team> GetTeams();
    }
}
