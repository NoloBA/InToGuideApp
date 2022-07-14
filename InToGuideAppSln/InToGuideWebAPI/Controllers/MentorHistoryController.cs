using InToGuideWebAPI.Enum;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MentorHistoryController : ControllerBase
    {
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public MentorHistoryController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
        }
        // GET all action
        [HttpPost]
        public IActionResult CreateNewMentorHistory([FromBody]MentorHistory mentorhistory)
        {
            try
            {
                return BadRequest(SystemErrorCodes.MentorHistoryNotFound);
            }
            catch(Exception argex)
            {
                return BadRequest(argex.Message);
            }
        }
        // GET by Id action
        [HttpGet]//HistoryID???
        public IEnumerable<MentorHistory> Get()
        {
            return _inToGuideRepossitory.GetMentorHistorys();
        }

        /*public IActionResult GetMentorHistory([FromBody] HistoryId historyid)//!!
        {
            return _inToGuideRepossitory.GetMentorHistory(historyid);
        */
        // POST action

        // PUT action

        // DELETE action
    }
}
