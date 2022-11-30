using Mecha2_API_core.Data;
using Mecha2_API_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mecha2_API_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private ApiDbContext _dbContext;

        public IssuesController(ApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/<IssuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _dbContext.Issues.ToListAsync());
        }

        // GET api/<IssuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var issue = await _dbContext.Issues.FindAsync(id);
            if (issue == null)
            {
                return NotFound("Select Failed: No record found for this issue");
            }
            else
            {
                return Ok(issue);
            }
                
        }

        // POST api/<IssuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Issue issue)
        {
            await _dbContext.Issues.AddAsync(issue);
            await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<IssuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Issue issueObj)
        {
            var issue = await _dbContext.Issues.FindAsync(id);
            if(issue == null)
            {
                return NotFound("Update Failed : No record found for this issue");
            }
            else
            {
                issue.IssueDate = issueObj.IssueDate;
                issue.LotNo = issueObj.LotNo;
                issue.EmployeeNo = issueObj.EmployeeNo;
                issue.Quantity = issueObj.Quantity;
                await _dbContext.SaveChangesAsync();
                return Ok("Record Updated Successfully");
            }
            
        }

        // DELETE api/<IssuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var issue = await _dbContext.Issues.FindAsync(id);
            if (issue == null)
            {
                return NotFound("Delete Failed : No record found for this issue");
            }
            else
            {
                _dbContext.Issues.Remove(issue);
                await _dbContext.SaveChangesAsync();
                return Ok("Record Deleted Successfully");
            }
                
        }
    }
}
