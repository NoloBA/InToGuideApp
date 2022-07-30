using System;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Services.Interfaces
{
    public interface IAppConfiguration
    {
        string InToGuideServerUrl { get; set; }
    }
}
