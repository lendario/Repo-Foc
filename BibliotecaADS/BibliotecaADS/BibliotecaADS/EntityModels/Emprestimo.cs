using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class Emprestimo
    {
        public int Id_emprestimo { get; set; }
        public DateTime dtSaida { get; set; }
        public DateTime dtPrevista { get; set; }
        public int Id_leitor { get; set; }
        public int Id_obra { get; set; }
        public int Id_funcionario { get; set; }

        public virtual Leitor Leitor { get; set; }
        public virtual ObraLiteraria ObraLiteraria { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual ICollection<Devolucao> Devolucoes  { get; set; }


    }
}
