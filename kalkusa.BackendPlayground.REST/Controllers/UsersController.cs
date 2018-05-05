using kalkusa.BackendPlayground.REST.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace kalkusa.BackendPlayground.REST.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new User[] {
                new User { Firstname = "Mark", Surname = "Zuckerberg", Id = new Guid() },
                new User { Firstname = "Bill", Surname = "Gates", Id = new Guid() }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return new User { Firstname = "Mark", Surname = "Zuckerberg", Id = new Guid() };
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}