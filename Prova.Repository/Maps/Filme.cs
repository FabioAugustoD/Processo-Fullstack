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
    public class FilmeMap : BaseDomainMap<Filme>
    {
       FilmeMap() : base("tb_filme") { }
       public override void Configure(EntityTypeBuilder<Filme> builder)
        {
            base.Configure(builder);
        }
    }
}
