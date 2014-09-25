using System.Data.Entity.ModelConfiguration;
using BibliotecaADS.EntityModels;

namespace BibliotecaADS.Mapping
{
    public class LeitorMap : EntityTypeConfiguration<Leitor>
    {
        public LeitorMap()
        {
            HasKey(l => l.Id_leitor);


            Property(l => l.nomeLeitor).HasMaxLength(50).IsRequired();
            Property(l => l.cpfLeitor).HasMaxLength(11).IsUnicode().IsRequired();
            Property(l => l.rgLeitor).HasMaxLength(11).IsUnicode().IsRequired();
            Property(l => l.sexoLeitor).HasMaxLength(1).IsRequired();
            Property(l => l.enderecoLeitor).HasMaxLength(128).IsRequired();
            Property(l => l.complementoLeitor).HasMaxLength(32).IsRequired();
            Property(l => l.cidadeLeitor).HasMaxLength(64).IsRequired();
            Property(l => l.ufLeitor).HasMaxLength(2).IsRequired();
            Property(l => l.emailLeitor).HasMaxLength(128).IsUnicode().IsRequired();
            Property(l => l.telefoneLeitor).HasMaxLength(11).IsRequired();
        }
    }
}
