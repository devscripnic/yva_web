namespace Domain.Entity;

public class UserEntity
{
    public required Guid Id { get; set; }
    public required string Email { get; set; }
    public required int RoleId { get; set; }
}