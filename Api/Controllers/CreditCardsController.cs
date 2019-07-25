using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Model;
using Api.Repository;
namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardsController : ControllerBase
    {
        private ICreditCardsRepository _repository;
        public CreditCardsController(ICreditCardsRepository creditCardsRepository)
        {
            _repository = creditCardsRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<CreditCard>> Get()
        {
            return _repository.GetAll().ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async void Post([FromBody] CreditCard value)
        {
            Console.WriteLine("Inside Post handler");
            Console.WriteLine(value.Id);
            await _repository.CreateAsync(value);
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
