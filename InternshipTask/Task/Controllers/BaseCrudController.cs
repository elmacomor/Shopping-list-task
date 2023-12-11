using Microsoft.AspNetCore.Mvc;
using TactaTask.Services;

namespace TactaTask.Controllers
{

    [Route("[controller]")]
    public class BaseCRUDController<T, TInsert, TUpdate> : BaseController<T> where T : class
    {
        protected new readonly ICrudService<T,TInsert, TUpdate> _service;
        protected readonly ILogger<BaseController<T>> _logger;

        public BaseCRUDController(ILogger<BaseController<T>> logger, ICrudService<T,TInsert, TUpdate> service)
            : base(service, logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpPost]
        public virtual async Task<IActionResult> Insert([FromBody] TInsert insert)
        {
            try
            {
                var result = await _service.Insert(insert);
                return Ok(result);
            }
            catch(Exception ex)
            {
               return BadRequest(ex.Message);
            }
        }


    }
}
