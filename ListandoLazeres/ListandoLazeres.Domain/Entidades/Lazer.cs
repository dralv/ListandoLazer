using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoLazeres.Domain.Entidades
{
    public class Lazer : EntidadeBase
    {
        public string NomeDoLazer { get; set; }
        public DateTime Data { get; set; }
        public Categoria Categoria { get; set; }
    }
}
