using InToGuideWebAPI.Enum;
using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Authorization;
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
        }

        // GET all n

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
        [HttpPost(nameof(CreateUser), Name = nameof(CreateUser))]
            public IActionResult CreateUser([FromBody] User user)
            {
                try
                {
                    if (user == null || !ModelState.IsValid)//no such user or invalid modelstate 
                    {
                        return BadRequest(SystemErrorCodes.UserNotValid.ToString());
                    }
                    bool userExists = _inToGuideRepossitory.DoesUserExistByEmailAddress(user.EmailAddress);//don't duplicate user/details
                    if (userExists)
                    {
                        return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.UserDuplicate.ToString());
                    }
                    _inToGuideRepossitory.CreateNewUser(user);//create user
                }
                catch (Exception ex)
                {
                    return BadRequest(SystemErrorCodes.AccountCreationFailed.ToString());
                }
                return Ok(user); //success
            }

            [HttpGet]
            public IActionResult GetUser(int UserId) //get existing user by uderId
            {
                try
                {
                    return Ok(_inToGuideRepossitory.GetUserByUserId(UserId));
                }
                catch (ArgumentException argex)
                {
                    return BadRequest(argex.Message);
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }

        
            
        }
    }
}