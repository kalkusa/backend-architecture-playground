using CQRSlite.Commands;
using CQRSlite.Domain;
using kalkusa.BackendPlayground.CQRS.WriteModel.Commands;
using kalkusa.BackendPlayground.CQRS.WriteModel.Domain;
using System.Threading.Tasks;

namespace kalkusa.BackendPlayground.CQRS.WriteModel.Handlers
{
    public class UserCommandHandlers : ICommandHandler<CreateUser>
    {
        private readonly ISession _session;

        public UserCommandHandlers(ISession session)
        {
            _session = session;
        }

        public async Task Handle(CreateUser message)
        {
            var item = new User(message.Id, message.Firstname, message.Surname);
            await _session.Add(item);
            await _session.Commit();
        }
    }
}