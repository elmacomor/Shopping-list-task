using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using TactaTask.Data;
using TactaTask.Models;
using TactaTask.Models.RequestModels;
using TactaTask.Models.ViewModels;

namespace TactaTask.Services
{
    public class ShoppingListService : BaseCrudService<ShoppingListVM, ShoppingList, ShoppingListInsertRequest, ShoppingListUpdateRequest>,IShoppingListService
    {
        public ShoppingListService(DBMainContext context, IMapper mapper) : base(context, mapper)
        {
        }
        public override bool InsertValidation(ShoppingListInsertRequest insert, List<ShoppingList> allItems)
        {
            const int limit = 3;
            if(allItems.Where(x=>x.ItemId==insert.ItemId).Count()>=limit)
            {
                return false;
            }
            if (allItems.Any(x => x.ItemId == insert.ItemId && x.ShopperId == insert.ShopperId))
            {
                return false;
            }
            return true;
        }

        public virtual async Task<List<ShoppingListVM>> GetById(int id)
        {
            var list = await _context.ShoppingList.Where(x => x.ShopperId == id).ToListAsync();

            return _mapper.Map<List<ShoppingListVM>>(list);
        }

    }
}
