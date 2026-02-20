using API.Dtos.ApiRequest;
using API.Dtos.ApiRequest.User;
using API.Dtos.ApiResponse;
using API.Dtos.ApiResponse.User;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.User.Auth;

[Route("user/auth/[controller]")]
public class RegistrationController : BaseController
{
    [HttpPost]
    public IActionResult Registration([FromBody] ApiRequestDto<UserRegistrationRequest> request)
    {
        return Ok(new ApiResponseDto<UserRegistrationResponse>(Data: new UserRegistrationResponse(Email: request.Data?.Password ?? "")));
    }
}