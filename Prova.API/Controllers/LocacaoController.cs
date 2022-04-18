using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Prova.Domain;
using Prova.Interface;

namespace Prova.API.Controllers
{
    [ApiController]    
    [Route("[controller]")]
    public class LocacaoController : AppBaseController
    {
        public LocacaoController(IServiceProvider serviceProvider): base(serviceProvider)
        { 
        }

        [HttpGet]
        public IEnumerable<Locacao> Get()
        {
            var rep = (ILocacaoRepository)ServiceProvider.GetService(typeof(ILocacaoRepository));
            return rep.Get();

        }
    }
}