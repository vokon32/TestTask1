using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestTask.BLL.Models;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TestTask.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/v1/[controller]")]
    public class BaseController<T, D> : ControllerBase where T : BaseModel
    {
        private readonly IBaseService<T, D> _service;

        public BaseController(IBaseService<T, D> service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            try
            {
                var data = await _service.All();
                return Ok(new ApiResponse<IList<D>>()
                {
                    Data = data,
                    Error = string.Empty,
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new ApiResponse<IList<D>>()
                {
                    Data = [],
                    Error = ex.Message,
                });
            }
        }
    }
}
