using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private  float promedioGoles;
        private  int totalGoles;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int Dni 
        {
            get
            {
                return dni;
            }
            set 
            {
                dni = value; 
            }
        }
        public string Nombre {
            get 
            {
                return nombre; 
            }
            set 
            { 
                nombre = value; 
            }
        }
        public int PartidosJugados
        {
            get
            {
                return partidosJugados;
            }
        }
        public float PromedioGoles {
            get
            {
                promedioGoles = ((float)this.totalGoles / (float)this.partidosJugados);
                return promedioGoles;
            }
        }
        public int TotalGoles {
            get
            {
                 
                return totalGoles;
            }
        }

        private Jugador()
        {
            this.promedioGoles = 0;
            this.partidosJugados = 0;
            this.totalGoles = 0;

        }
        public Jugador(int dni, string nombre):this()  // con esto estoy llamando el metodo de la linea 17
        {
            this.Dni = dni;
            this.Nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre) // con esto estoy llamando el metodo de la linea 24
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
            this.promedioGoles = PromedioGoles;
        }

        public float GetPromedioGoles() 
        {
             float promedio = ((float)this.totalGoles / (float)this.partidosJugados);
            return this.promedioGoles = promedio;
        }

       
        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
          
            sb.AppendLine("DNI: " + this.Dni);
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Partidos Jugados: " + this.PartidosJugados);
            sb.AppendLine("total goles: " + this.TotalGoles);
            sb.AppendLine("Promedio Goles: " + PromedioGoles); 
            
            
            return sb.ToString();
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Dni == j2.Dni;
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
    }



}
