using CQRSlite.Commands;
using kalkusa.BackendPlayground.CQRS.ReadModel;
using kalkusa.BackendPlayground.CQRS.ReadModel.DTOs;
using kalkusa.BackendPlayground.CQRS.WriteModel.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace kalkusa.BackendPlayground.REST.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly ICommandSender commandSender;
        private readonly IReadModelFacade readmodel;

        public UsersController(ICommandSender commandSender,
                               IReadModelFacade readmodel)
        {
            this.readmodel = readmodel;
            this.commandSender = commandSender;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return readmodel.GetUsers();
        }

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public User Get(string id)
        //{
        //    return new User { Firstname = "Mark", Surname = "Zuckerberg", Id = new Guid() };
        //}

        [HttpPost]
        public Guid Post([FromBody]User user)
        {
            Guid guid = Guid.NewGuid();
            commandSender.Send(new CreateUser(guid, user.Firstname, user.Surname));
            return guid;
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}