using Mecha2_API_core.Data;
using Mecha2_API_core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mecha2_API_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssueDetailsController : ControllerBase
    {
        private ApiDbContext _dbContext;
        public IssueDetailsController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<IssueDetailsController>
        [HttpGet]
        public IEnumerable<IssueDetail> Get()
        {
            return _dbContext.IssueDetails;
        }

        // GET api/<IssueDetailsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IssueDetailsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IssueDetailsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IssueDetailsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
