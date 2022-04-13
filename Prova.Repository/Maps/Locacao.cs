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
       public LocacaoMap() : base("tb_locacao") { }
       public override void Configure(EntityTypeBuilder<Locacao> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.IdCliente).HasColumnName("id_cliente").IsRequired();
            builder.HasOne(x => x.Cliente).WithMany(x => x.Locacoes).HasForeignKey(x => x.IdCliente);

            builder.Property(x => x.IdFilme).HasColumnName("id_filme").IsRequired();
            builder.HasOne(x => x.Filme).WithMany(x => x.Locacoes).HasForeignKey(x => x.IdFilme);
        }
    }
}
