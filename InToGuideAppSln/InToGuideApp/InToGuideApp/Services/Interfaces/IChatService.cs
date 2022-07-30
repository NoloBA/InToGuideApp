using System;
using System.Collections.Generic;
using System.Text;
using InToGuideApp.Services.Core;
using InToGuideApp.Services.Interfaces;
using System.Threading.Tasks;

namespace InToGuideApp.Services.Interfaces
{
    public interface IChatService
    {
        Task Connect();
            
        Task Disconnect();

        Task SendMessage(string userId, string message//bool isPrivate = false
            );

        void ReceiveMessage(Action<string, string> GetMessageAndUser);
    }
}
