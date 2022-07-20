using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string AccountType { get; set; }

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
    }
}
