using AutoMapper;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using TactaTask.Models;
using TactaTask.Models.RequestModels;
using TactaTask.Models.ViewModels;

namespace TactaTask.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Shopper, ShopperVM>();
            CreateMap<Item, ItemVM>();
            CreateMap<ShoppingListInsertRequest, ShoppingList>();
            CreateMap<ShoppingList, ShoppingListVM>();
        }
    }
}
