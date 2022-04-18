using Prova.Domain;
using Prova.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Repository
{
    public class FilmeRepository : BaseRepository, IFilmeRepository
    {    
        public FilmeRepository(ApplicationDbContext dbContext) : base(dbContext)
        {           
        }

        public List<Filme> Get()
        {
            return DbContext.Filmes.ToList();
        }
    }
}
