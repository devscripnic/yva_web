using API.Dtos.Enum;

namespace API.Dtos.ApiResponse;

public sealed record ApiResponseDto<T>(T? Data = default, ClientAction? ClientAction = default, int? Status = default, string? ErrorMsg = default);