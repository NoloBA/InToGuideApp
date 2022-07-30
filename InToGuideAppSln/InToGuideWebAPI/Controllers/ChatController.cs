using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public ChatController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
        }
        
        //public IActionResult CreateChat([FromBody] Chat chat)
        //{
        //    return (IActionResult)_inToGuideRepossitory.CreateChat(chat);//missing cast
        //}

        /*[HttpGet]
        public IActionResult GetChat(string chatId)
        {
            return (IActionResult)_inToGuideRepossitory.GetChat(chatId);//missing caast
        }*/

//        [HttpGet]
//        public IEnumerable<Chat>GetChats(string chatId)
//        {
//            try
//            {
//                if (chatId == null)
//                {
//                    return (IEnumerable<Chat>)BadRequest();
//                }
//                _inToGuideRepossitory.GetChatList();
//            }

//            catch (Exception argex)
//            {
//                return (IEnumerable<Chat>)BadRequest(argex.Message);//Explicit cast
//            }
                
            


//            return _inToGuideRepossitory.GetChatList();
//        }
//           // {}
//        // GET all action

//        // GET by Id action

//        // POST action

//        // PUT action

//        // DELETE action
    }
}
