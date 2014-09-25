using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class Devolucao
    {
        public int Id_devolucao { get; set; }
        public DateTime dtReal { get; set; }
        public decimal valorDevolucao { get; set; }
        public int Id_emprestimo { get; set; }

        public virtual Emprestimo Emprestimo { get; set; }
    }
}
