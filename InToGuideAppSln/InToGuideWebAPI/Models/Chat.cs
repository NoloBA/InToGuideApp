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

        public int UserID { get; set; }

        public string CommentMessage { get; set; }

        public DateTime Time { get; set; }

        public DateTime Date { get; set; }



        [ForeignKey("")]
        public int AuthenticationId { get; set; }



    }
}
