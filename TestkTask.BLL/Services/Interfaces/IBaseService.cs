using TestTask.BLL.Models;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services.Interfaces
{
    public interface IBaseService<T, D> where T : BaseModel
    {
        Task<IList<D>> All();
        Task<IList<D>> ReadByFilter(Filter filter);
    }
}
