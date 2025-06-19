
using AutoMapper;
using TestTask.BLL.Models.DTO;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Data;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services
{
    public class UserService : BaseService<User, UserDto>, IUserService
    {
        public UserService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
