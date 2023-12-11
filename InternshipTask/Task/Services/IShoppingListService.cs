using TactaTask.Models.RequestModels;
using TactaTask.Models.ViewModels;

namespace TactaTask.Services
{
    public interface IShoppingListService:ICrudService<ShoppingListVM,ShoppingListInsertRequest,ShoppingListUpdateRequest>
    {
        Task<List<ShoppingListVM>> GetById(int id);
    }
}
