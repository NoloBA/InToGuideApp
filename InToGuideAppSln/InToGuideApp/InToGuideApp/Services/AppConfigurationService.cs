using InToGuideApp.Services.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace InToGuideApp.Services
{
    public class AppConfigurationService : IAppConfiguration
    {
        private string _inToGuideServerUrl;

        public string InToGuideServerUrl { get => _inToGuideServerUrl; set => _inToGuideServerUrl = value; }

        public AppConfigurationService()
        {
#if LOCALSERVER
                _inToGuideServerUrl = "https://10.0.2.2:7267/";
#else
            _inToGuideServerUrl = "http://localhost:7267/";
#endif
        }
    }
}
