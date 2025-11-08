using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace story_brook_api.Models
{
    public class WishBook
    {
        [Key]
        [Column("id")]
        [MaxLength(36)]
        public string? Id { get; set; }

        [Column("user_id")]
        public string? UserId { get; set; }


        [Column("book_id")]
        public string? BookId { get; set; }

        [ForeignKey("UserId")]
        public User? User { get; set; }
    }
}
