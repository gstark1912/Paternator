using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entities
{
    public class Partido
    {
        public int IDPartido { get; set; }
        public int IDJugadorLocal { get; set; }
        public int IDJugadorVisitante { get; set; }
        public int IDEquipoLocal { get; set; }
        public int IDEquipoVisitante { get; set; }
        public int GolesLocal { get; set; }
        public int GolesVisitante { get; set; }
        public DateTime FechaPartido { get; set; }
        public int IDResultadoPartido { get; set; }
        public int IDJuegoVersion { get; set; }
        public bool Aprobado { get; set; }
        public Nullable<DateTime> FechaAprobacion { get; set; }
    }
}
