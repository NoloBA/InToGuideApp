using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public MatchController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
        }
        // GET all action
        [HttpPost]
        public IActionResult CreateNewMatch([FromBody] Match match)
        {
            return _inToGuideRepossitory.CreateNewMatch();
        }

        [HttpGet]//Getby MatchID
        public IEnumerable<Match> Get()
        {
           // int MatchId = 0;//MatchID
            return _inToGuideRepossitory.GetAllMatches();//ienumerable id!!
        }
        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}
