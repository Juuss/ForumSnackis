using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Snackis.Models
{
    public class ChattMessage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string SenderId { get; set; }
        public string RecipientId { get; set; }
        public DateTime SentTime { get; set; }
        public string Message { get; set; }
    }
}
