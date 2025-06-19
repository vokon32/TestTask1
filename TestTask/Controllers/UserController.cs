using TestTask.BLL.Models.DTO;
using TestTask.BLL.Services;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;

namespace TestTask.API.Controllers
{
    public class UserController : BaseController<User, UserDto>
    {
        public UserController(IUserService service) : base(service)
        {
        }
    }
}
