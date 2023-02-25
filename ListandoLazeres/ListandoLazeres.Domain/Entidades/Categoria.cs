using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoLazeres.Domain.Entidades
{
    public class Categoria:EntidadeBase
    {
        public string Nome { get; set; }
        public ICollection<Lazer> Lazeres { get; set; }
    }
}
