using Prova.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Interface
{
    public interface IClienteRepository
    {
        List<Cliente> Get();
    }
}
