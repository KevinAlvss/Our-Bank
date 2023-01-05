namespace OurBank.Contracts.AuthentIcation;

public record AuthenticationResponse (
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string Token
);