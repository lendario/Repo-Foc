using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class EmprestimoMap : EntityTypeConfiguration<Emprestimo>
    {
        public EmprestimoMap()
        {
            HasKey(e => e.Id_emprestimo);


            Property(e => e.dtSaida).IsRequired();
            Property(e => e.dtPrevista).IsRequired();

            
            
            //-------Relacionamentos--------//
            //Obra
            HasRequired(e => e.ObraLiteraria)
                .WithMany(e => e.Emprestimos)
                .HasForeignKey(e => e.Id_obra);
            
            //Leitor
            HasRequired(e => e.Leitor)
                .WithMany(e => e.Emprestimos)
                .HasForeignKey(e => e.Id_leitor);
            
            //Funcionário
            HasRequired(e => e.Funcionario)
                .WithMany(e => e.Emprestimos)
                .HasForeignKey(e => e.Id_funcionario);
        }
    }
}
