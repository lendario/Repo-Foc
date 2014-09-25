using System.Data.Entity;
using BibliotecaADS.Mapping;

namespace BibliotecaADS.EntityModels
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext()
            : base("name=Conexao")
        {
        }


        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Leitor> Leitores { get; set; }
        public DbSet<ObraLiteraria> ObrasLiterarias { get; set; }
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EditoraMap());
            modelBuilder.Configurations.Add(new LeitorMap());
            modelBuilder.Configurations.Add(new ObraLiterariaMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new EmprestimoMap());
            modelBuilder.Configurations.Add(new DevolucaoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
