namespace OurBank.Application.Services.Authentication;

public interface IAuthenticationService {
    AuthenticationResponse Login(string Email, string Password);
    AuthenticationResponse Register(string FirstName, string LastName, string Email, string Password);
}