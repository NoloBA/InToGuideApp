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
        public IActionResult CreateReview([FromBody] Review review)
        {
            try
            {
                if (review == null || !ModelState.IsValid)//no such user or invalid modelstate 
                {
                    return BadRequest(SystemErrorCodes.UserNotValid.ToString());
                }
                bool reviewExists = _inToGuideRepossitory.DoesReviewExistById(review.ReviewId );//don't duplicate
                if (reviewExists)
                {
                    return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.UserDuplicate.ToString());
                }
                _inToGuideRepossitory.CreateNewReview(review);//create user
            }
            catch (Exception ex)
            {
                return BadRequest(SystemErrorCodes.ReviewCreationFailed.ToString());
            }
            return Ok(review); //success
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
