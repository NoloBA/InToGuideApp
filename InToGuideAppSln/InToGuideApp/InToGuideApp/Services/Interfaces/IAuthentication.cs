using InToGuideShared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InToGuideApp.Services.Interfaces
{
    public interface IAuthentication
    {
        Task<AuthenticationResponse> Authenticate(string emailAddress, string password);
    }
}
