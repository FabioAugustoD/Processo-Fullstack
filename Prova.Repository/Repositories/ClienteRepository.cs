using Prova.Domain;
using Prova.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Repository
{
    public class ClienteRepository : BaseRepository, IClienteRepository
    {    
        public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {           
        }

        public List<Cliente> Get()
        {
            return DbContext.Clientes.ToList();
        }
    }
}
