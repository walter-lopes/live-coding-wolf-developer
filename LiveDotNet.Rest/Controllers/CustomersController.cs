using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiveDotNet.Rest.Domain.Entities;
using LiveDotNet.Rest.Domain.Interfaces.Repositories;
using LiveDotNet.Rest.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiveDotNet.Rest.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
           return _customerRepository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer)
        {
            _customerRepository.Save(customer);
            return Ok();
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
