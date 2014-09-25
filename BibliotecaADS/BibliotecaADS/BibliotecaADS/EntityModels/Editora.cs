using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaADS.EntityModels
{
    public class Editora
    {
        public int Id_editora { get; set; }
        public string nomeEditora { get; set; }
        public string cnpjEditora { get; set; }
        public string telefoneEditora { get; set; }
        public string emailEditora { get; set; }
        public string siteEditora { get; set; }

        public virtual ICollection<ObraLiteraria> ObrasLiterarias { get; set; }
    }
}
