using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using basicEFDemo.Repository;
using basicEFDemo.Models;
namespace basicEFDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRepository _repository;
        public ValuesController(IRepository repository)
        {
            _repository = repository;
        }
        // GET api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetAsync()
        {
            var orders = await _repository.GetAllAsync();
            return Ok(orders);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetAsync(int id)
        {
            var order = await _repository.GetAsync(id);
            return Ok(order);
        }

        // POST api/values
        [HttpPost]
        public Task Post([FromBody] Order order)
        {
            return Task.FromResult(_repository.Create(order));
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
