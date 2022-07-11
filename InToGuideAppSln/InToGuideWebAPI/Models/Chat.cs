using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    [Table("Chat")]
    public class Chat
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public string MenteeMessage { get; set; }
        public string MentorMessage { get; set; }


        public DateTime Time { get; set; }

        public DateTime Date { get; set; }

        public int ThreadId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        //public User? User { get; set; }


    }
}
