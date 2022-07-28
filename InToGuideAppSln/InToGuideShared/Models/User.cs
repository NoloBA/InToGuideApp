using System;
using System.Collections.Generic;
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

        public int AccountType { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Qualification { get; set; }

        public string Institution { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Hobbies { get; set; }

        public string IdNumber { get; set; }

        public string Profession { get; set; } //for mentor only

        public string Company { get; set; } //for mentor only

        public string PhoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public DateTime Date { get; set; }


        [ForeignKey("Authentication")]
        public int AuthenticationId { get; set; }

        public Authentication? Authentication { get; set; }

    /*    [ForeignKey("Review")]
        public int ReviewId { get; set; }

        public Review? Review { get; set; }
    */

/*        [ForeignKey("HelpAndSupport")]
        public int EnquiryId { get; set; }

        public HelpAndSupport? HelpAndSupport { get; set; }
*/

        [ForeignKey("Certificate")]
        public int CertificateId { get; set; }
        public ICollection<Certificate>? Certificates { get; set; }


        //[ForeignKey("Match")]
        //public int MatchId { get; set; }

        //public Match MenteeMatch { get; set; }
        //public Match MentorMatch { get; set; }



        //[ForeignKey("MentorHistory")]
        //public int HistoryId { get; set; }

        //public MentorHistory? MentorHistory { get; set; }
        



        //[ForeignKey("Chat")]
        //public ICollection<User> chats { get; set; }
        //public string ChatId { get; set; }

        //public Chat? MenteeChat { get; set; }

        //public Chat? MentorChat { get; set; }






    }


}
