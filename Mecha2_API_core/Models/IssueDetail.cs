using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mecha2_API_core.Models
{
    public class IssueDetail
    {
        public int Id { get; set; }
        [Required]
        public string SAPNo { get; set; }
        [Required]
        public string ItemNo { get; set; }
        [Required]
        public string WOSNo { get; set; }
        [Required]
        public string DrawingNo { get; set; }
        [Required]
        public string LotNo { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int IssueId { get; set; }
    }
}
