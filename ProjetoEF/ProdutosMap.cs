using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEF
{
    public class ProdutosMap : EntityTypeConfiguration<Produtos>
    {

        public ProdutosMap() 
        {
            ToTable("Produtos");
            HasKey(x => x.Id);
            Property(x => x.Descricao).IsRequired().HasColumnType("varchar").HasMaxLength(70);
            Property(x => x.Un).IsRequired().HasColumnType("varchar").HasMaxLength(3);
            Property(x => x.Unitario).HasColumnType("decimal").HasPrecision(10,2);
            Property(x => x.IdSetor).HasColumnType("int");
        }
    }
}
