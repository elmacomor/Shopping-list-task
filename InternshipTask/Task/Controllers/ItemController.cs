using Microsoft.AspNetCore.Mvc;
using TactaTask.Models.ViewModels;
using TactaTask.Services;

namespace TactaTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : BaseController<ItemVM>
    {
        public ItemController(IItemService service, ILogger<BaseController<ItemVM>> logger) : base(service, logger)
        {
        }
    }
}
