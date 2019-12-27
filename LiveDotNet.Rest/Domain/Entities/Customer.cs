using System;

namespace LiveDotNet.Rest.Domain.Entities
{
    public class Customer
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string CPF { get; private set; }

        public DateTime Created { get; private set; }

        public Customer(string name, string cpf)
        {
            this.Name = name;
            this.CPF = cpf;
            Id = Guid.NewGuid();
            Created = DateTime.Now;
        }

        public bool IsSpecial()
        {
            return DateTime.Now.Year - Created.Year >= 5;
        }
    }
}
