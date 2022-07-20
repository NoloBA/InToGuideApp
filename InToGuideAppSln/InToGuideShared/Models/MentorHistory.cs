using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    [Table ("MentorHistory")]
    public class MentorHistory
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int HistoryId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User/*?*/ User { get; set; }

    }
}
