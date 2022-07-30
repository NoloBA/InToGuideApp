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

        [ForeignKey("User")]

        public int? MenteeId { get; set; }
        public User? Mentee { get; set; }

        [ForeignKey("User")]

        public int? MentorId { get; set; }
        public User? Mentor { get; set; }








    }
}
