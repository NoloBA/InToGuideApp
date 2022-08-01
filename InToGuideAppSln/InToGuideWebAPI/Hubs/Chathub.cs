using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.SignalR;

namespace InToGuideWebAPI.Hubs
{
    public class Chathub : Hub
    {
        /*private readonly IUserManager usersManger;

            public Chathub(IUserManager userManager) 
        {
            this.userManager = userManager;
        }*/

        public async Task SendMessage(string userId, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage");
        }

        public async Task OnConnect()
        {
/*            var user = usersManager.GetUserByEmail);
            usersManager.AddUserConnects(new ConnectionModel)
            {
                ConnectionID = Context.ConnectionI,
                    IsConnected = true,
                    UserAgent = Context.GetHttpContext().Request.Headers["User-Agent"],
                    UserID = user.ID
            });
*/
            base.OnConnectedAsync();
        }


        /*public async Task SendPrivateMessage(string userEmail, string message) 
        { 
        var friend = usersManager.GetUserByEmail(userEmail);
        var friendConnections = friend.Connections.Where(x => x.IsConnected);
        foreach (var connection in friendConnections)
        {
        await Clients.Others.SendAsync("ReceiveMessage", userEmail, message);
        }
        }

        public async Task OnConnect(string userEmail)
        {
            var user = usersManager.GetUserByEmail);
            usersManager.AddUserConnects(new ConnectionModel)
            { 
            ConnectionID = Context.ConnectionI,
                    IsConnected= true,
                    UserAgent = Context.GetHttpContext().Request.Headers["User-Agent"],
                    UserID = user.ID
            });

            base.OnConnectedAsync();
        }
        
        public asyn Task OnDisconnect(string userEmail)
        {
        var user  = usersManager.GetUserEmail(userEmail);
        userManager.UpdateUserConnectionStatus(user.ID, false, Context.ConnectionId)
        }
         
         */
    }
}
