using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{

    public class NumbersRepo
    {
        List<int> numbers = new List<int>(){42, 45, 0};
        public int[] GetAll() => numbers.ToArray();
    }
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private NumbersRepo repo;

        public ValuesController(NumbersRepo repo)
        {
            this.repo = repo;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<int> Get()
        {
            return repo.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
