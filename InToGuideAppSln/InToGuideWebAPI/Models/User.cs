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

        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }

        public Certificate? Certificate { get; set; }
        //public ICollection<Certificate>? Certificates { get; set; }

        [ForeignKey("Chat")]
        public string MenteeMessage { get; set; }

        public Chat? MenteeChat { get; set; }

        [ForeignKey("Chat")]
        public string MentorMessage { get; set; }

        public Chat? MentorChat { get; set; }

        [ForeignKey("HelpAndSupport")]
        public int EnquiryId { get; set; }

        public HelpAndSupport? HelpAndSupport { get; set; }


        [ForeignKey("Match")]
        public int MentorId { get; set; }

        public Match? MenteeMatch { get; set; }

        [ForeignKey("Match")]
        public int MenteeId { get; set; }

        public Match? MentorMatch { get; set; }



        [ForeignKey("MentorHistory")]
        public int HistoryId { get; set; }

        public MentorHistory? MentorHistory { get; set; }


        [ForeignKey("Review")]
        public int ReviewMessage { get; set; }

        public Review? Review { get; set; }
    }


}
