using kalkusa.BackendPlayground.CQRS.ReadModel.DTOs;
using kalkusa.BackendPlayground.CQRS.ReadModel.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace kalkusa.BackendPlayground.CQRS.ReadModel
{
    public class ReadModelFacade : IReadModelFacade
    {
        public User GetUser(Guid id)
        {
            return InMemoryDatabase.Users.Where(user => user.Id == id).Single();
        }

        public IEnumerable<User> GetUsers()
        {
            return InMemoryDatabase.Users;
        }
    }
}