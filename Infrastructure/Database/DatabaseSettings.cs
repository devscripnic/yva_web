namespace Infrastructure.Database;
public class DatabaseSettings
{
    public string Host { get; set; } = "";
    public string Database { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";

    public static DatabaseSettings FromEnvironment(string env)
    {
        var dbHost = "DB_HOST";
        var dbDatabaseName = "DB_NAME";
        var dbUserKey = "DB_USER";
        var dbUserPassword = "DB_PASSWORD";

        return new DatabaseSettings
        {
            Host = Environment.GetEnvironmentVariable(dbHost) ?? "",
            Database = Environment.GetEnvironmentVariable(dbDatabaseName) ?? "",
            Username = Environment.GetEnvironmentVariable(dbUserKey) ?? "",
            Password = Environment.GetEnvironmentVariable(dbUserPassword) ?? ""
        };
    }

    public string GetConnectionString()
    {
        return $"Host={Host};Database={Database};Username={Username};Password={Password}";
    }
}