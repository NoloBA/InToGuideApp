using InToGuideWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Services.Interfaces
{
    public interface IDataCache
    {
        bool IsAuthenticated { get; set; }

        User AuthenticatedUser { get; set; }
    }
}
