using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyForum.BL.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [MaxLength(100)]
        [Display(Name = "A Text")]
        public string? Text { get; set; }

        [Display(Name = "An Image")]
        public byte? Img { get; set; }

        [ForeignKey("Post")]
        public int PostId { get; set; }
        public Post? Post { get; set; }
    }
}
