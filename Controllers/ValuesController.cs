using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExRepository.Models;
using ExRepository.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace ExRepository.Controllers {

    [Route ("api/[controller]")]
    public class ValuesController :Controller {
        private readonly IValueRepository valueRepository;

        public ValuesController (IValueRepository valueRepository) {
            this.valueRepository = valueRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get () {
            var values=this.valueRepository.AsQueryable();
            return new OkObjectResult(values);
        }

        // GET api/values/5
        [HttpGet ("{id}")]
        public ActionResult<string> Get (int id) {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post (ValueModel value) {
            this.valueRepository.Add(value);
        }

        // PUT api/values/5
        [HttpPut ("{id}")]
        public void Put (int id, [FromBody] string value) { }

        // DELETE api/values/5
        [HttpDelete ("{id}")]
        public void Delete (int id) { }
    }
}