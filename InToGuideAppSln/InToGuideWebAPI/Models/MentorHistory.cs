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


        [ForeignKey("UserInfo")]
        public int UserId { get; set; }

        public User? User { get; set; }

    }
}
