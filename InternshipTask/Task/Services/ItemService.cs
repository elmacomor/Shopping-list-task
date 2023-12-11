using AutoMapper;
using eDentist.Services.Services;
using TactaTask.Data;
using TactaTask.Models;
using TactaTask.Models.ViewModels;

namespace TactaTask.Services
{
    public class ItemService : BaseService<ItemVM, Item>, IItemService
    {
        public ItemService(DBMainContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
