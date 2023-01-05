using Microsoft.AspNetCore.Mvc;
using OurBank.Application.Services.Authentication;
using OurBank.Contracts.AuthentIcation;

namespace OurBank.Api.Controllers;

[ApiController]
[Route ("auth")]
public class AuthenticationController : ControllerBase {
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request){
        var response = _authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request){
        var response = _authenticationService.Login(request.Email, request.Password);
        return Ok(response);
    }
}