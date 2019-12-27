using LiveDotNet.Rest.Context;
using LiveDotNet.Rest.Domain.Entities;
using LiveDotNet.Rest.Domain.Interfaces.Repositories;
using MongoDB.Driver;
using System.Collections.Generic;

namespace LiveDotNet.Rest.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private IDbContext DbContext { get; set; }

        private IMongoCollection<Customer> Collection { get; set; }

        public CustomerRepository(IDbContext context)
        {
            this.DbContext = context;
            this.Collection = context.Context.GetCollection<Customer>("Customers");
        }

        public IEnumerable<Customer> GetAll()
        {
           var result =   this.Collection.Find(FilterDefinition<Customer>.Empty);

            if ( result == null)
            {
                return new List<Customer>();
            }

            return result.ToList();
        }

        public void Save(Customer customer)  =>  this.Collection.InsertOne(customer);    
    }
}
