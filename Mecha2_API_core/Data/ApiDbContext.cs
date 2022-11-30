using Mecha2_API_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecha2_API_core.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }
        public DbSet<IssueDetail> IssueDetails { get; set; }
    }
}
