using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;


        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre):this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public static bool operator +(Equipo e, Jugador j) 
        {
            if (e.jugadores.Count == 0) // ve si la cantidad de jugadores en la lista es igual a 0 
            {
                e.jugadores.Add(j);//agregar el jugador 
                return true;
            } 
            else if (e.jugadores.Count < e.cantidadDeJugadores) // 
            {
                foreach( Jugador aux in e.jugadores)
                {
                    if (j == aux) 
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}
