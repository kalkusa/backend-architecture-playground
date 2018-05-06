using CQRSlite.Events;
using System;

namespace kalkusa.BackendPlayground.CQRS.ReadModel.Events
{
    public class UserCreated : IEvent
    {
        public readonly string Firstname;
        public readonly string Surname;

        public UserCreated(Guid id, string firstname, string surname)
        {
            Id = id;
            Firstname = firstname;
            Surname = surname;
        }

        public Guid Id { get; set; }
        public int Version { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
    }
}