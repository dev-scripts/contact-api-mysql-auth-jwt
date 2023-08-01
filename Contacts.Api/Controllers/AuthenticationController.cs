using System.ComponentModel.DataAnnotations;
using Contacts.Api.Requests;
using Microsoft.AspNetCore.Mvc;
using Contacts.Api.Services;

namespace Contacts.Api.Controllers;

[ApiController]
[Route("api/auth")]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService authentication;

    public AuthenticationController(IAuthenticationService authentication)
    {
        this.authentication = authentication;
    }

    [HttpPost]
    [Route("registration")]
    public async Task<IActionResult> Registration(UserRegistrationRequest request)
    {
        try
        {
           var user =  await authentication.Registration(request);

           return Ok(user);
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost]
    [Route("login")]
    public async Task<IActionResult> Login(UserLoginRequest request)
    {
        try
        {
            var user = await authentication.Login(request);

            return Ok(user);
        }
        catch (ValidationException ex)
        {
            return BadRequest(ex.ValidationResult);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}