using Commanders.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var command = new List<Command>
            {
                new Command { Id = 0, Howto="Boil an egg", Line="boil water",Platform="duyanh" },
                new Command { Id = 1, Howto = "Boil an egg", Line = "boil water", Platform = "duyanh" },
                new Command { Id = 2, Howto = "Boil an egg", Line = "boil water", Platform = "duyanh" },
                new Command { Id = 3, Howto = "Boil an egg", Line = "boil water", Platform = "duyanh" }
            };
            return command;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, Howto = "Boil an egg", Line = "boil water", Platform = "duyanh" };
        }
    }
}
