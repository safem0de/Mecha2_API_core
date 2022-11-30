using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mecha2_API_core.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        public string LotNo { get; set; }
        [Required]
        public string EmployeeNo { get; set; }
        [Required]
        public int Quantity { get; set; }

        public ICollection<IssueDetail> IssueDetails { get; set; }
    }
}
