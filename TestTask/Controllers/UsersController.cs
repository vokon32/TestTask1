using TestTask.BLL.Models.DTO;
using TestTask.BLL.Services;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Models;

namespace TestTask.API.Controllers
{
    public class UsersController : BaseController<User, UserDto>
    {
        public UsersController(IUserService service) : base(service)
        {
        }
    }
}
