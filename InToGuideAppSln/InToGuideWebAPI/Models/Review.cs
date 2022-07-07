using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    public class Review
    {
        [Table("Review")]
        public class Chat
        {
            [Required]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public string ReviewMessage { get; set; }

            public DateTime Time { get; set; }

            public DateTime Date { get; set; }

            public int Rating { get; set; }


            [ForeignKey("User")]
            public int UserID { get; set; }
            public User? User { get; set; }
        }
    }
}
