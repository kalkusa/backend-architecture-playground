using CQRSlite.Commands;
using System;

namespace kalkusa.BackendPlayground.CQRS.WriteModel.Commands
{
    public class CreateUser : ICommand
    {
        public readonly string Firstname;
        public readonly string Surname;

        public CreateUser(Guid id, string firstname, string surname)
        {
            Id = id;
            Surname = surname;
            Firstname = firstname;
        }

        public Guid Id { get; set; }
    }
}