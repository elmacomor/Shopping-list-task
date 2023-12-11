using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TactaTask.Data;
using TactaTask.Services;
namespace eDentist.Services.Services
{
    public class BaseService<T,TDb> : IService<T> where T : class where TDb:class
    {
        protected DBMainContext _context;
        protected IMapper _mapper { get; set; }

        public BaseService(DBMainContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual async Task<List<T>> Get()
        {
            var query = _context.Set<TDb>().AsQueryable();
            var list = await query.ToListAsync();
            return _mapper.Map<List<T>>(list);
        }

       

    }
}
