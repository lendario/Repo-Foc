using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class Funcionario
    {
        public int Id_funcionario { get; set; }
        public string nomeFuncionario { get; set; }
        public string rgFuncionario { get; set; }
        public string cpfFuncionario { get; set; }
        public decimal salarioFuncionario { get; set; }
        public string sexoFuncionario { get; set; }
        public string enderecoFuncionario { get; set; }
        public string complementoFuncionario { get; set; }
        public string cidadeFuncionario { get; set; }
        public string ufLeitor { get; set; }
        public string emailFuncionario { get; set; }
        public string telefoneFuncionario { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }
    }
}
