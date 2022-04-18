using Microsoft.AspNetCore.Mvc;
using Prova.Domain;
using Prova.Interface;


namespace Prova.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : AppBaseController
    {
        public ClienteController(IServiceProvider serviceProvider): base(serviceProvider)
        { 
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            var rep = (IClienteRepository)ServiceProvider.GetService(typeof(IClienteRepository));
            return rep.Get();

        }
    }
}