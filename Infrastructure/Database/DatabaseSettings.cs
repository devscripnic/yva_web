public class DatabaseSettings
{
    public string Host { get; set; } = "";
    public string Database { get; set; } = "";
    public string Username { get; set; } = "";
    public string Password { get; set; } = "!";

    public static DatabaseSettings FromEnvironment(string env)
    {
        var dbHost = env == "Development" ? "DB_HOST" : "DB_HOST";
        var dbDatabaseName = env == "Development" ? "DB_NAME" : "DB_NAME";
        var dbUserKey = env == "Development" ? "DB_ADMIN_USER" : "DB_APP_USER";
        var dbUserPassword = env == "Development" ? "DB_ADMIN_PASSWORD" : "DB_APP_PASSWORD";

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