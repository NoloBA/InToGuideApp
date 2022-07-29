using InToGuideShared;
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


        [HttpPost]
        public IActionResult Post([FromBody] AuthenticationRequest authRequest)
        {
            var authResponse = new AuthenticationResponse();

            try
            {
                var result = _inToGuideRepossitory.PerformAuthenticationCheck(authRequest.EmailAddress, authRequest.Password);

                if (result)
                {
                    var authentication = _inToGuideRepossitory.GetAuthentication(authRequest.EmailAddress, authRequest.Password);

                    if (authentication != null)
                    {
                        var user = _inToGuideRepossitory.GetUserByAuthenticationId(authentication.AuthenticationId);

                        if (user != null)
                        {
                            authResponse.Authenticated = true;
                            authResponse.AuthenticatedUser = user;
                        }
                    }

                }

                return Ok(authResponse);
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
            //public IActionResult Post([FromBody] AuthenticationRequest authRequest)
            //{
            //    try
            //    {
            //        return Ok(_inToGuideRepossitory.PerformAuthenticationCheck(authRequest.EmailAddress, authRequest.Password));
            //    }
            //    catch (AccessViolationException)
            //    {
            //        return BadRequest();
            //    }
            //    catch (Exception)
            //    {
            //        return StatusCode(StatusCodes.Status500InternalServerError);
            //    }
            //}

    }

   
}

