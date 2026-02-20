using API.Dtos.ApiRequest;
using API.Dtos.ApiRequest.User;
using API.Dtos.ApiResponse;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.User.Auth;

[Route("user/auth/[controller]")]
public class LoginController : BaseController
{
    [HttpPost]
    public IActionResult Registration([FromBody] ApiRequestDto<UserLoginRequest> request)
    {
        return Ok(new ApiResponseDto<UserLoginResponse>(Data: new UserLoginResponse(Token: request.Data?.Password ?? "")));
    }
}