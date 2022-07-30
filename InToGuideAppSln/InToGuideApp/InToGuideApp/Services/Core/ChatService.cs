using System;
using System.Collections.Generic;
using System.Text;
using InToGuideApp.Services.Interfaces;
using InToGuideApp.Services.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;
using Prism.Commands;
using Prism.Navigation;
using Microsoft.AspNetCore.Http.Connections.Client;

namespace InToGuideApp.Services.Core
{
    public class ChatService : IChatService
    {
        private readonly HubConnection hubConnection;

        private IHttpNativeHandler _handler;

        public ChatService(IHttpNativeHandler handler)
        {
            _handler = handler;


            hubConnection = new HubConnectionBuilder().WithUrl("https://10.0.2.2:7267/Chathub",
                options =>
                {
                    options.HttpMessageHandlerFactory = factory => handler.GetHttpClientHandler();
                }
                ).Build();
        
            //hubConnection = new HubConnectionBuilder().WithUrl("").Build();
        }

        public async Task Connect()
        {
            
            await hubConnection.StartAsync();


            //await hubConnection.InvokeAsync("OnConnect",userEmail);
        }

        public async Task Disconnect()
        {
            await hubConnection?.StopAsync();
            //await hubConnection.InvokeAsync("OnDisconnect",userEmail);
        }

        public async Task SendMessage(string userId, string message)
        {
            await hubConnection.InvokeAsync("SendMessage", userId, message);
        }

        public void ReceiveMessage(Action<string, string> GetMessageAndUser)
        {
            hubConnection.On("ReceiveMessage", GetMessageAndUser);
        }

        
    }
    
}
