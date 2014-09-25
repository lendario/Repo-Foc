using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class DevolucaoMap : EntityTypeConfiguration<Devolucao>
    {
        public DevolucaoMap()
        {
            HasKey(d => d.Id_devolucao);

            Property(d => d.dtReal).IsRequired();
            Property(d => d.valorDevolucao).IsRequired();

            //Relacionamento
            HasRequired(d => d.Emprestimo)
                .WithMany(d => d.Devolucoes)
                .HasForeignKey(d => d.Id_emprestimo);
        }
    }
}
