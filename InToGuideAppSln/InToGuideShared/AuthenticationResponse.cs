using InToGuideWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideShared
{
    public class AuthenticationResponse
    {
        public bool  Authenticated { get; set; }

        public User AuthenticatedUser { get; set; }

        public AuthenticationResponse()
        {
            Authenticated = false;
            AuthenticatedUser = null;
        }
    }
}
