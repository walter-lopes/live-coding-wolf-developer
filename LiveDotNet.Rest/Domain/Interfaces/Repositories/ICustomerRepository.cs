using LiveDotNet.Rest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveDotNet.Rest.Domain.Interfaces.Repositories
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);

        IEnumerable<Customer> GetAll();
    }

}
