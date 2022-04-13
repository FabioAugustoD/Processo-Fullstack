using Microsoft.AspNetCore.Mvc;

namespace Prova.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppBaseController : ControllerBase
    {
        protected readonly IServiceProvider ServiceProvider;

        public AppBaseController(IServiceProvider serviceProvider)
        {
            ServiceProvider = serviceProvider;
        }

    }
}