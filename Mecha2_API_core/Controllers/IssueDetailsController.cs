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
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _dbContext.IssueDetails.ToListAsync());
        }

        // POST api/<IssueDetailsController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] IssueDetail issuedetail)
        {
            await _dbContext.IssueDetails.AddAsync(issuedetail);
            await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);
        }

        // PUT api/<IssueDetailsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] IssueDetail issueDetailObj)
        {
            var issuedetail = await _dbContext.IssueDetails.FindAsync(id);
            if (issuedetail == null)
            {
                return NotFound("Update Failed : No record found for this issuedetail");
            }
            else
            {
                issuedetail.SAPNo = issueDetailObj.SAPNo;
                issuedetail.ItemNo = issueDetailObj.ItemNo;
                issuedetail.WOSNo = issueDetailObj.WOSNo;
                issuedetail.DrawingNo = issueDetailObj.DrawingNo;
                issuedetail.LotNo = issueDetailObj.LotNo;
                issuedetail.Quantity = issueDetailObj.Quantity;
                issuedetail.IssueId = issueDetailObj.IssueId;
                return Ok("Record Updated Successfully");
            }
            
        }

        // DELETE api/<IssueDetailsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var issuedetail = await _dbContext.IssueDetails.FindAsync(id);
            if (issuedetail == null)
            {
                return NotFound("Delete Failed : No record found for this issuedetail");
            }
            else
            {
                _dbContext.IssueDetails.Remove(issuedetail);
                await _dbContext.SaveChangesAsync();
                return Ok("Record Deleted Successfully");
            }
        }
    }
}
