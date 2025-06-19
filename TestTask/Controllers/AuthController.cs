using Microsoft.AspNetCore.Mvc;
using TestTask.BLL.Models;
using TestTask.BLL.Models.DTO;
using TestTask.BLL.Services.Interfaces;

namespace TestTask.API.Controllers
{
    [Route("api/v1/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _service;

        public AuthController(IAuthService service)
        {
            _service = service;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LoginDto model)
        {
            try
            {
                var data = await _service.Register(model.Email, model.Password);

                return Ok(new ApiResponse<bool>()
                {
                    Data = data,
                    Error = null

                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<bool>()
                {
                    Data = false,
                    Error = ex.Message
                });
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto model)
        {
            try
            {
                var data = await _service.Login(model.Email, model.Password);

                return Ok(new ApiResponse<string>()
                {
                    Data = data,
                    Error = null

                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<string>
                {
                    Data = null,
                    Error = ex.Message
                });
            }
        }
    }
}
