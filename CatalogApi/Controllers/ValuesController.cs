using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CatalogApi.Controllers
{

    public class Order{

        public string Id  {get; set;}
        public decimal Amount {get; set;}

        public Order(string id,decimal amount)
        {
            Id=id;
            Amount=amount;
        }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
  


        [HttpGet, Route("")]
        public ActionResult GetOrders()
        {
            var o1 = new Order("ID1",200);
            var o2 = new Order("ID1",400);
            return Ok(new List<Order>{o1,o2});
        }



        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<IEnumerable<string>> Get(int id)
        {
            return new string[] {"value",id.ToString()};
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
