using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TactaTask.Models.RequestModels;
using TactaTask.Models.ViewModels;
using TactaTask.Services;

namespace TactaTask.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingListController : BaseCRUDController<ShoppingListVM, ShoppingListInsertRequest, ShoppingListUpdateRequest>
    {
        public ShoppingListController(ILogger<BaseController<ShoppingListVM>> logger, IShoppingListService service) : base(logger, service)
        {
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShoppingListVM>> GetById(int id)
        {
            var item = await (_service as IShoppingListService).GetById(id);
            return Ok(item); 
        }
    }
}
  