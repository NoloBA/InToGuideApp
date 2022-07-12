using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
        [Table("Review")]
        public class Review
        {
            [Required]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public int ReviewId { get; set; }

            public DateTime Time { get; set; }

            public DateTime Date { get; set; }

            public int Rating { get; set; }


            [ForeignKey("User")]
            public int UserId { get; set; }
            //public User? User { get; set; }
        }
    
}
