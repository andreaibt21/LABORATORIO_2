using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private Estadistica estadistica;
        private List<Jugador> listaJugadores;
        private Entrenador entrenador;
        private string nombreEquipo;

        public Entrenador Entrenador 
        {
            get 
            {
                return this.entrenador; 
            }
            set 
            {
                if (value is not null) 
                {
                    this.entrenador = value; 
                }
            }
        }
        public Estadistica Estadistica 
        {
            get 
            {
                return this.estadistica; 
            }
            set
            {
                if (value is not null)
                {
                    this.estadistica = value;
                }
            }
        }
        public List<Jugador> ListaJugadores 
        {
            get
            {
                return this.listaJugadores;
            }
            set
            {
                this.listaJugadores = value;
            }  
        }
        public string NombreEquipo
        {
            get
            {
                return this.nombreEquipo;
            }
            set
            {
                this.nombreEquipo = value;
            }
        }

        public Equipo(string nombreEquipo, Entrenador entrenador, List<Jugador> listaJugadores)
        {
            this.listaJugadores = listaJugadores;
            this.entrenador = entrenador;
            this.nombreEquipo = nombreEquipo;
            this.estadistica = new Estadistica();
        }
    }//fin clas equipo
}
