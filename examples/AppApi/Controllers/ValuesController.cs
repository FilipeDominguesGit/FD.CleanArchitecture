using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppApi.OutputBoundaries;
using AppCore;
using Microsoft.AspNetCore.Mvc;

namespace AppApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]string value)
        {
            var request = new SumTwoNumbersRequest(1, 2);
            var outputBoundary = new SumTwoNumbersOutputBoundary();
            var usecase = new SumTwoNumbersUseCase(outputBoundary);
            

            usecase.Execute(request);


            return Json(outputBoundary.Response);
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
