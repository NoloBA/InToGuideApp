using InToGuideApp.Services.Interfaces;
using InToGuideWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Services
{
    public class InMemoryDataCache : IDataCache
    {
        public bool IsAuthenticated { get; set; }

        public User AuthenticatedUser { get; set; }
    }
}
