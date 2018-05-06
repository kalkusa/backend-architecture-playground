using kalkusa.BackendPlayground.Persistence.DatabaseModels;
using System;
using System.Collections.Generic;

namespace kalkusa.BackendPlayground.Persistence.Queries
{
    public interface IUserQueries
    {
        IEnumerable<User> GetUsers();

        User GetUser(Guid id);
    }
}