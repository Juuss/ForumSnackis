using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snackis
{
    public class Report
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int PostId { get; set; }
        public string ReportedBy { get; set; }
        public DateTime ReportTime { get; set; }
        public string Reason { get; set; }
        public bool BeenHandled { get; set; }

    }
}
