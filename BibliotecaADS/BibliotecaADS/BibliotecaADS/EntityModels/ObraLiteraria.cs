using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class ObraLiteraria
    {
        public int Id_obra { get; set; }
        public string tituloObra { get; set; }
        public int edicaoObra { get; set; }
        public string autorObra { get; set; }
        public int qtdObra { get; set; }
        public string localizacaoObra { get; set; }
        public int codigoObra { get; set; }
        public int Id_editora { get; set; }

        public virtual Editora Editora { get; set; }
        public virtual ICollection<Emprestimo> Emprestimos { get; set; }

    }
}