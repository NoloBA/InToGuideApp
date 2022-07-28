using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InToGuideApp.Services.Interfaces
{
    public interface IAuthentication
    {
        Task<bool> Authenticate(string emailAddress, string password);
    }
}
