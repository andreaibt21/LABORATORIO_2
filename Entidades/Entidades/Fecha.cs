using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fecha
    {

        private int id;
        private List<Partido> partidos;

        public Fecha(int id, List<Partido> partidos)
        {
            this.id = id;
            this.partidos = partidos;
        }

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public List<Partido> Partidos
        {
            get { return this.partidos; }
            set { this.partidos = value; }
        }
    }//class fin fecad
}
