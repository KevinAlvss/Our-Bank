using OurBank.Domain.Entities;

namespace OurBank.Application.Common.Interfaces;

public interface IUserRepository {
    void Add(User user);
    User? GetUserByEmail(string email);
}