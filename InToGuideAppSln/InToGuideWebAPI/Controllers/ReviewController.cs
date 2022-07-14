using InToGuideWebAPI.Enum;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public ReviewController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
        }
        
        [HttpPost]
        public IActionResult CreateNewReview([FromBody] Review review)//Get review from body
        {
            try
            {
                if (review == null)
                {
                    return BadRequest(SystemErrorCodes.ReviewBodyEmpty);
                }

                return Ok(review);
            }
            catch
            {
                return BadRequest(SystemErrorCodes.ReviewNotCreated);
            }
        }

        [HttpGet]
        public IEnumerable<Review> Get()
        {
            return _inToGuideRepossitory.GetAllReviews(); //Get list of reviews
        }


        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
    }
}
