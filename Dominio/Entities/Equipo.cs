using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Equipo
    {
        public int IDEquipo { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionAbreviada { get; set; }
        public int IDLiga { get; set; }
    }
}
