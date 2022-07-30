using System.Net.Http;

namespace InToGuideApp.Services.Interfaces
{
    public interface IHttpNativeHandler
    {
        HttpClientHandler GetHttpClientHandler();
    }
}