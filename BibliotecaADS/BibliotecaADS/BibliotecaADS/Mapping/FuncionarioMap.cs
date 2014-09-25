using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class FuncionarioMap : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMap()
        {
            HasKey(l => l.Id_funcionario);


            Property(l => l.nomeFuncionario).HasMaxLength(50).IsRequired();
            Property(l => l.cpfFuncionario).HasMaxLength(11).IsUnicode().IsRequired();
            Property(l => l.rgFuncionario).HasMaxLength(11).IsUnicode().IsRequired();
            Property(l => l.sexoFuncionario).HasMaxLength(1).IsRequired();
            Property(l => l.enderecoFuncionario).HasMaxLength(128).IsRequired();
            Property(l => l.complementoFuncionario).HasMaxLength(32).IsRequired();
            Property(l => l.cidadeFuncionario).HasMaxLength(64).IsRequired();
            Property(l => l.ufLeitor).HasMaxLength(2).IsRequired();
            Property(l => l.emailFuncionario).HasMaxLength(128).IsUnicode().IsRequired();
            Property(l => l.telefoneFuncionario).HasMaxLength(11).IsRequired();
            Property(l => l.salarioFuncionario).IsRequired();
        }
    }
}
