using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechnicalRadiation.Services;

namespace TechnicalRadiation.Controllers
{
    [Route("api")]
    [ApiController]
    public class Controller : ControllerBase
    {
        private NewsItemService _newsItemService = new NewsItemService();
        // GET api/""
        [Route("")]
        [HttpGet]
        public IActionResult GetAllNewsItems ([FromQuery] bool containUnavailable)
        {
            
            return Ok(_newsItemService.GetAllNewsItems());
        }

         // GET api/values/5
        [HttpGet("{id:int}")]
        public ActionResult<string> GetAllNewsItems(int id)
        {
            return Ok();
        }
/*
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
        }*/
    }
}
