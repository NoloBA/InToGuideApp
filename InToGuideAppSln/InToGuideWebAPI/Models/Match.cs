using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    [Table("Match")]
    public class Match
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int MatchId { get; set; }
        public int MenteeId { get; set; }
        public int MentorId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public  User? User { get; set; }

        



    }
}
