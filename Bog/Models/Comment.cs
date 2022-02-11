using System.ComponentModel.DataAnnotations;

namespace Bog.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string? Title { get; set; }
        public string? Name { get; set; }
        [Display(Name ="Comment Date")]
        public DateTime CommentDate { get; set; }
        public string? Body { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }

    }
}
