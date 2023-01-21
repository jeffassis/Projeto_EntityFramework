using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEF
{
    public class ClientesMap : EntityTypeConfiguration<Clientes>
    {

        public ClientesMap()
        {
            ToTable("Clientes");
            HasKey(x => x.Id);
            Property(x => x.Nome).HasColumnName("NomeCliente").HasColumnType("varchar").HasMaxLength(70);
        }    
    }
}
