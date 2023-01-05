using OurBank.Domain.Entities;

namespace OurBank.Application.Common.Authentication;

public interface IJwtTokenGenerator {
    string GenerateToken(User user);
}