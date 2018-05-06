using System;

namespace kalkusa.BackendPlayground.Persistence.DatabaseModels
{
    public class User
    {
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public Guid Id { get; set; }
    }
}