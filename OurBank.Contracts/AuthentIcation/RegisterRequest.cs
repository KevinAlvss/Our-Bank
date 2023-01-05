namespace OurBank.Contracts.AuthentIcation;

public record RegisterRequest (
    string FirstName,
    string LastName,
    string Email,
    string Password
);