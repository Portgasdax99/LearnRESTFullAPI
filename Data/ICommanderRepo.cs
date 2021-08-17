using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Commanders.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAppCommands();
        Command GetCommandById(int id);
    }
}
