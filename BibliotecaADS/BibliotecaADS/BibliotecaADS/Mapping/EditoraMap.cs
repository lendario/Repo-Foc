using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class EditoraMap : EntityTypeConfiguration<Editora>
    {
        public EditoraMap()
        {
            ToTable("Editora");

            //Chave primária
            HasKey(e => e.Id_editora);

            //Propriedades
            Property(e => e.nomeEditora).HasMaxLength(30).IsUnicode().IsRequired();
            Property(e => e.cnpjEditora).HasMaxLength(14).IsUnicode().IsRequired();
            Property(e => e.emailEditora).HasMaxLength(128).IsUnicode().IsRequired();
            Property(e => e.siteEditora).HasMaxLength(128).IsUnicode().IsOptional();
            Property(e => e.telefoneEditora).HasMaxLength(11).IsUnicode().IsRequired();
        }
    }
}
