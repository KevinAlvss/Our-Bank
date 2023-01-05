
using OurBank.Domain.Entities;

namespace OurBank.Application.Services.Authentication;

public record AuthenticationResponse(
    User User,
    string Token
);