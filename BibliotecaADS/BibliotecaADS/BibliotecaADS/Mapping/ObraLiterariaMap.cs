using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class ObraLiterariaMap : EntityTypeConfiguration<ObraLiteraria>
    {
        public ObraLiterariaMap()
        {
            ToTable("ObrasLiterarias");

            //Chave primária
            HasKey(o => o.Id_obra);

            //Propriedades
            Property(o => o.tituloObra).HasMaxLength(40).IsRequired();
            Property(o => o.edicaoObra).IsRequired();
            Property(o => o.autorObra).HasMaxLength(40).IsRequired();
            Property(o => o.codigoObra).IsRequired();
            Property(o => o.localizacaoObra).HasMaxLength(5).IsRequired();
            Property(o => o.qtdObra).IsRequired();
            




            //Relacionamento
            HasRequired(o => o.Editora)
                .WithMany(o => o.ObrasLiterarias)
                .HasForeignKey(o => o.Id_editora);
        }
    }
}
