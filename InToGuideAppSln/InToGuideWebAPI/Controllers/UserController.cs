using InToGuideWebAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public UserController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
            // GET all action

            // GET by Id action

            // POST action

            // PUT action

            // DELETE action
        }
    }
}
