namespace Shared.Identity;
public static class RoleDefinitions
{
    public static class Admin
    {
        public static readonly Guid Id =
            Guid.Parse("11111111-1111-1111-1111-111111111111");

        public const string Name = "Admin";
    }

    public static class User
    {
        public static readonly Guid Id =
            Guid.Parse("22222222-2222-2222-2222-222222222222");

        public const string Name = "User";
    }
}