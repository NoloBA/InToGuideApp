
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    [Table("Authentication")]
    public class Authentication 
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int AuthenticationId { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool VerificationStatus { get; set; }
        public bool Enabled { get; internal set; }
    }
}
