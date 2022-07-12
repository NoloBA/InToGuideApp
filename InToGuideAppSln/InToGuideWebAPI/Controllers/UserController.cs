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
            [HttpPost]
            public IActionResult CreateUser([FromBody] User user)
            {
                try
                {
                    if (user == null || !ModelState.IsValid)
                    {
                        return BadRequest(SystemErrorCodes.UserNotValid.ToString());
                    }
                    bool customerExists = _inToGuideRepossitory.DoesEmailAddresExistByUser(user.EmailAddress);
                    if (customerExists)
                    {
                        return StatusCode(StatusCodes.Status409Conflict, SystemErrorCodes.UserDuplicate.ToString());
                    }
                    _inToGuideRepossitory.CreateNewUser(user);
                }
                catch (Exception)
                {
                    return BadRequest(SystemErrorCodes.AccountCreationFailed.ToString());
                }
                return Ok(user);
            }

            [HttpGet]
            public async Task<IActionResult> GetUser(int UserId)
            {
                try
                {
                    return Ok(await _inToGuideRepossitory.CreateNewUser());
                }
                catch (ArgumentException argex)
                {
                    return BadRequest(argex.Message);
                }
                catch (Exception)
                {
                    return StatusCode(500);
             }
            /* public IEnumerable<Customer> Get()
            {
                return _bankingDbRepository.GetAllCustomers();
            }*/
        
            
            /*[HttpDelete]
            [Authorize(Roles = "Admin")]
            [Authorize(Roles = "Regular")]
            public async Task<IActionResult> Delete(string userId)
            {
                try
                {
                    await _inToGuideRepossitory. (userId);
                    return NoContent();
                }
                catch (MissingMemberException mmex)
                {
                    return BadRequest(mmex.Message);
                }
                catch (ArgumentException argex)
                {
                    return BadRequest(argex.Message);
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }
            }*/
        }
    }
}