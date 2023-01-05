using OurBank.Application.Common.Authentication;
using OurBank.Application.Common.Interfaces;
using OurBank.Domain.Entities;

namespace OurBank.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService {

    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator, IUserRepository userRepository)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResponse Login(string email, string password)
    {
        var user = _userRepository.GetUserByEmail(email);

        if(user is null || user.Password != password){
            throw new Exception("The email or password you have entered is incorrect.");
        }

        var token = _jwtTokenGenerator.GenerateToken(user);

        var response = new AuthenticationResponse(user, token);
        return response;
    }

    public AuthenticationResponse Register(string firstName, string lastName, string email, string password)
    {
        if(_userRepository.GetUserByEmail(email) is not null){
            throw new Exception("The email address you have entered is already in use.");
        }

        var user = new User {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password
            };

        _userRepository.Add(user);

        var token = _jwtTokenGenerator.GenerateToken(user);

        var response = new AuthenticationResponse(user, token);
        return response;
    }
}