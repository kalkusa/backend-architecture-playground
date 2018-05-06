using CQRSlite.Events;
using kalkusa.BackendPlayground.CQRS.ReadModel.DTOs;
using kalkusa.BackendPlayground.CQRS.ReadModel.Events;
using kalkusa.BackendPlayground.CQRS.ReadModel.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace kalkusa.BackendPlayground.CQRS.ReadModel.Handlers
{
    public class UserList : ICancellableEventHandler<UserCreated>
    {
        public Task Handle(UserCreated message, CancellationToken token)
        {
            InMemoryDatabase.Users.Add(new User { Id = message.Id, Firstname = message.Firstname, Surname = message.Surname });
            return Task.CompletedTask;
        }
    }
}