using InToGuideWebAPI.Interfaces;
using InToGuideWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InToGuideWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        // GET all action

        // GET by Id action

        // POST action

        // PUT action

        // DELETE action
        private readonly IInToGuideRepossitory _inToGuideRepossitory;

        public AuthenticationController(IInToGuideRepossitory inToGuideRepossitory)
        {
            _inToGuideRepossitory = inToGuideRepossitory;
        }


        [HttpPost("login")]
        public IActionResult Post([FromBody] AuthenticationRequest authRequest)
        {
            try
            {
                return Ok(_inToGuideRepossitory.PerformAuthenticationCheck(authRequest.EmailAdress, authRequest.Password));
            }
            catch (AccessViolationException)
            {
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

    }

   
}

