namespace API.Dtos.ApiRequest.User;

public sealed record UserRegistrationRequest(string? Email = default, string? Password = default, string? ConfirmationPassword = default);