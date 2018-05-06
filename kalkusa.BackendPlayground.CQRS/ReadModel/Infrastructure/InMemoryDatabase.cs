using kalkusa.BackendPlayground.CQRS.ReadModel.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace kalkusa.BackendPlayground.CQRS.ReadModel.Infrastructure
{
    public static class InMemoryDatabase 
    {
        public static readonly List<User> Users = new List<User>();
    }
}
