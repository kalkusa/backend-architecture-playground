using kalkusa.BackendPlayground.CQRS.ReadModel.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace kalkusa.BackendPlayground.CQRS.ReadModel
{
    public interface IReadModelFacade
    {
        IEnumerable<User> GetUsers();
        User GetUser(Guid id);
    }
}
