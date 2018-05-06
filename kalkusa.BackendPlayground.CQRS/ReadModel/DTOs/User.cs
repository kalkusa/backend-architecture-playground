using System;

namespace kalkusa.BackendPlayground.CQRS.ReadModel.DTOs
{
    public class User
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Guid Id { get; set; }
    }
}