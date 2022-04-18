using Prova.Domain;
using Prova.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Repository
{
    public class LocacaoRepository : BaseRepository, ILocacaoRepository
    {    
        public LocacaoRepository(ApplicationDbContext dbContext) : base(dbContext)
        {           
        }

        public List<Locacao> Get()
        {
            return DbContext.Locacoes.ToList();
        }
    }
}
