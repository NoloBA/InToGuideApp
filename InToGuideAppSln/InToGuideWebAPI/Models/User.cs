using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
{
    [Table("User")]
    public class User
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int UserId { get; set; }

        public bool AccountType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Qualification { get; set; }

        public string Institution { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Hobbies { get; set; }

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public DateTime Date { get; set; }

        [ForeignKey("Authentication")]
        public int AuthenticationId { get; set; }

        public Authentication? Authentication { get; set; }

        public ICollection<Certificate>? Certificates { get; set; }
    }


}
