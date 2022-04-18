using Microsoft.AspNetCore.Mvc;
using Prova.Domain;
using Prova.Interface;


namespace Prova.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : AppBaseController
    {
        public FilmeController(IServiceProvider serviceProvider): base(serviceProvider)
        { 
        }

        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            var rep = (IFilmeRepository)ServiceProvider.GetService(typeof(IFilmeRepository));
            return rep.Get();

        }
    }
}