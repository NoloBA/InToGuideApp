using System;
using System.Collections.Generic;
using InToGuideApp.Models;
using InToGuideWebAPI.Models;
using System.Text;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using InToGuideApp.ViewModels;
using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using InToGuideApp.Services.Interfaces;
using System.Windows.Input;
using System.Linq;

namespace InToGuideApp.ViewModels
{
    public class ChatViewModel: ViewModelBase
    {
        private readonly IChatService chatService;

        private string fullname;
        public string FullName
        {
            get { return fullname; }
            set { SetProperty(ref fullname, value); }
        }

        private string message;
        public string Message 
        { 
            get => message;
        set => SetProperty(ref message, value);
        }

       

        private IEnumerable<MessageModel> messageList;

        public IEnumerable<MessageModel> MessagesList
        { 
            get => messageList; 
            set => SetProperty(ref messageList, value); 
            
        }

        public ICommand SendMsgCommand
        {
            get;
            private set;
        }
       

        public ChatViewModel(
            INavigationService navigationService, 
            IChatService chatService): 
            base(navigationService) 
        {
           this.chatService = chatService;
            SendMsgCommand = new DelegateCommand(SendMsg);
        }

        public override async void Initialize(INavigationParameters parameters)
        {
          //  UserName = parameters.GetValue<string>("UserNameId");
            //base.Initialize(parameters);
            //await chatService.Connect();
            MessagesList = new List<MessageModel>();
            try
            {
                chatService.ReceiveMessage(GetMessage);
                await chatService.Connect();
            }
            catch (System.Exception exp)
            {
                throw;
            }


        }

            private void SendMsg()
            {
                chatService.SendMessage(fullname, Message);
                
                AddMessage(fullname, Message, true);
            }

        private void AddMessage(string message, string FullName, bool IsOwner)
        {
            var tempList = MessagesList.ToList();
            tempList.Add(new MessageModel { IsOwnerMessage = IsOwner, Message = message, fullname = FullName });
            MessagesList = new List<MessageModel>(tempList);
            Message = string.Empty;
        }

        private void GetMessage( string message, string fullName)
            {
                AddMessage(fullname, message, false);
            }

       /* public async Task SendMessage(string user, string message)
        {
            await .All.SendAsync("ReceiveMessage", user, message);
        }*/



    }
}
        
            
