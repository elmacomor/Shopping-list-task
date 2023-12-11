using AutoMapper;
using eDentist.Services.Services;
using Microsoft.AspNetCore.Mvc;
using TactaTask.Data;

namespace TactaTask.Services
{
    public class BaseCrudService<T, TDB, Tinsert, Tupdate> : BaseService<T, TDB> where T : class where TDB : class
    {
        public BaseCrudService(DBMainContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual bool InsertValidation(Tinsert insert,List<TDB> allItems)
        {
            return true;
        }
        public virtual async Task<T> Insert(Tinsert obj)
        {
           
            var table = _context.Set<TDB>();
            TDB entity = _mapper.Map<TDB>(obj);
            var allItems = table.ToList();
            bool validation = InsertValidation(obj, allItems);
            if (!validation)
            {
                throw new Exception("Invalid input.");
            }
            table.Add(entity);
            await _context.SaveChangesAsync();
            return _mapper.Map<T>(entity);
           
        }

    }
}
