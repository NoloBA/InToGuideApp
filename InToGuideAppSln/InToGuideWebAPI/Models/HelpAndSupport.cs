using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InToGuideWebAPI.Models
     

{
    [Table("HelpAndSupport")]
    public class HelpAndSupport
    {
      
       
            [Required]
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

            public int EnquiryId { get; set; }          

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string EmailAddress { get; set; }

            public string Message { get; set; }

            public string EnquiryID { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }

        //public ICollection<BankAccount>? BankAccounts { get; set; }
    }

    }

