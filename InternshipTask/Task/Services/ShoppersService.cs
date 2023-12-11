using AutoMapper;
using eDentist.Services.Services;
using Microsoft.EntityFrameworkCore;
using TactaTask.Data;
using TactaTask.Models;
using TactaTask.Models.ViewModels;

namespace TactaTask.Services
{
    public class ShoppersService : BaseService<ShopperVM,Shopper>, IShoppersService
    {
        public ShoppersService(DBMainContext context, IMapper mapper) : base(context, mapper)
        {
        }
     
    }
}
