using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.BLL.Models.DTO;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services.Interfaces
{
    public interface IUserService : IBaseService<User, UserDto>
    {
    }
}
