using Microsoft.AspNetCore.Mvc;

namespace Prova.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocacaoController : AppBaseController
    {
        public LocacaoController(IServiceProvider serviceProvider): base(serviceProvider)
        { 
        }

    }
}