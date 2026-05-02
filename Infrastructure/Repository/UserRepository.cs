using Domain.Entity;
using Domain.Repository;

namespace Infrastructure.Repository;
class UserRepository : IUserRepository
{
    public Task AddAsync(UserEntity user)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExistsByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<UserEntity?> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}