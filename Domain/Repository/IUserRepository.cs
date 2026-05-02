using Domain.Entity;

namespace Domain.Repository;
public interface IUserRepository
{
    Task<UserEntity?> GetByIdAsync(Guid id);
    Task<UserEntity?> GetByEmailAsync(string email);
    Task AddAsync(UserEntity user);
    Task<bool> ExistsByEmailAsync(string email);
}