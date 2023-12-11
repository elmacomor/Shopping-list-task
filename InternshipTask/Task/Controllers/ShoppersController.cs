using Microsoft.AspNetCore.Mvc;
using TactaTask.Models.ViewModels;
using TactaTask.Services;

namespace TactaTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppersController : BaseController<ShopperVM>
    {
        public ShoppersController(IShoppersService service, ILogger<BaseController<ShopperVM>> logger) : base(service, logger)
        {
        }
    }
}
