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

        public string Message { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; }

        public string ThreadID { get; set; }


        [ForeignKey("User")]
        public int UserID { get; set; }



    }
}
