using System.ComponentModel.DataAnnotations;

namespace Bog.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string? Title { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public string? Body { get; set; }
        public string? Username { get; set; }
        List<Comment>? Comments { get; set; }
    }
}