using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Entrenador : Deportista
    {
        private bool campeonDelMundo;
        private int cantEquiposDirigidos;



        public Entrenador( string nombreApellido, int edad, int cantidadPartidos, int cantEquiposDirigidos, bool campeonDelMundo)
            : base(nombreApellido, edad, cantEquiposDirigidos)
        {
            this.campeonDelMundo = campeonDelMundo;
            this.cantEquiposDirigidos = cantEquiposDirigidos;

        }

        public bool CampeonDelMundo
        {
            get { return this.campeonDelMundo; }

        }
        public int CantEquiposDirigidos
        {
            get { return this.cantEquiposDirigidos; }

        }

    }
}
