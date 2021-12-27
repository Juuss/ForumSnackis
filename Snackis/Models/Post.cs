using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snackis
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public DateTime PostedOn { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string PostText { get; set; }
        public string Title { get; set; }
        public int AnswerTo { get; set; }

    }
}
