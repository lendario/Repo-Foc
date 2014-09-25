using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class Leitor
    {
        public int Id_leitor { get; set; }
        public string cpfLeitor { get; set; }
        public string nomeLeitor { get; set; }
        public string rgLeitor { get; set; }
        public string enderecoLeitor { get; set; }
        public string complementoLeitor { get; set; }
        public string ufLeitor  { get; set; }
        public string cidadeLeitor { get; set; }
        public string emailLeitor { get; set; }
        public string telefoneLeitor { get; set; }
        public string sexoLeitor { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
