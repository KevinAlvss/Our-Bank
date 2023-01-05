namespace OurBank.Contracts.AuthentIcation;

public record LoginRequest (
    string Email,
    string Password
);