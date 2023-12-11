using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TactaTask.Services;

namespace TactaTask.Controllers
{
    [Route("[controller]")]
    public class BaseController<T> : ControllerBase where T : class
    {
        protected readonly IService<T> _service;
        protected readonly ILogger<BaseController<T>> _logger;

        public BaseController(IService<T> service, ILogger<BaseController<T>> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<T>> Get()
        {
            return await _service.Get();
        }
    }
}
