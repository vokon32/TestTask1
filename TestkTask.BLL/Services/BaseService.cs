
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestTask.BLL.Models;
using TestTask.BLL.Services.Interfaces;
using TestTask.DAL.Data;
using TestTask.DAL.Models;

namespace TestTask.BLL.Services
{
    public class BaseService<T,D> : IBaseService<T, D> where T : BaseModel
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public BaseService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IList<D>> All()
        {
            return await _mapper.ProjectTo<D>(_context.Set<T>().Where(s => !s.IsDeleted)).ToListAsync();
        }

    }
}
