using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Repository.Maps
{
    public class LocacaoMap : BaseDomainMap<Locacao>
    {
       LocacaoMap() : base("tb_locacao") { }
       public override void Configure(EntityTypeBuilder<Locacao> builder)
        {
            base.Configure(builder);

        }
    }
}
