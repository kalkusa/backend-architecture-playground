using System;

namespace kalkusa.BackendPlayground.REST.Models
{
    public class User
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Guid Id { get; set; }
    }
}