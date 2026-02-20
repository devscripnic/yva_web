namespace API.Dtos.ApiRequest.User;

public sealed record UserLoginRequest(string? Email = default, string? Password = default);