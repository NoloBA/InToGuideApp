using InToGuideWebAPI.Interfaces;
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
        public IActionResult Post([FromBody] AuthRequest authRequest)
        {
            try
            {
                return Ok (_inToGuideRepossitory.PerformAuthenticationCheck());
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

        /*[HttpPost("register")]
        public async Task<IActionResult> Register(RegisterationRequest registerationRequest)
        {
            try
            {
                var result = await _authentication.Register(registerationRequest);

                return Created("", result);
            }
            catch (MissingFieldException msex)
            {
                return BadRequest(msex.Message);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("GetUserEmail")]
        public async Task<IActionResult> GetUserEmail([FromQuery] UserEmailRequest userEmailRequest)
        {
            try
            {
                var user = await _authentication.GetUserEmail(userEmailRequest);
                if (!(user.Data == null))
                {
                    return Ok(user);
                }
                return NotFound(user);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }*/
    }

    public class AuthRequest
    {
    }
}

