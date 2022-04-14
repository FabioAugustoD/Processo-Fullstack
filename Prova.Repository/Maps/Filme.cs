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
        public FilmeMap() : base("tb_filme") { }
       public override void Configure(EntityTypeBuilder<Filme> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Titulo).HasColumnName("titulo").HasMaxLength(100).IsRequired();
            builder.Property(x => x.ClassificacaoIndicativa).HasColumnName("classificacao").IsRequired();
            builder.Property(x => x.Lancamento).HasColumnName("lancamento").IsRequired();

        }
    }
}
