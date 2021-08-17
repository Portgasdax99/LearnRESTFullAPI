using Commander.Data;
using Commanders.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }


        // private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        // Get api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItems = _repository.GetCommandById(id);
            return Ok(commandItems);
        }
    }
}
