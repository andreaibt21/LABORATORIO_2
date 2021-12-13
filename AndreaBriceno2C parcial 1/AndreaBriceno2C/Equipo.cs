using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdido;
        protected int puntuacion;

     


        #region PROPIEDADES

        /// <summary>
        /// Propiedad de lectura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo partidos empatados
        /// </summary>
        /// FALTÓ VALIDAR SET
        public int PE
        {
            get 
            { 
                return this.partidosEmpatados; 
            }
            set 
            {
                if (value >= 0)
                { this.partidosEmpatados = value; }
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo partidos ganados
        /// </summary>
        public int PG
        {
            get 
            {
                return this.partidosGanados; 
            }
            set 
            {
                if (value >= 0)
                {
                    this.partidosGanados = value;
                }
            }
        }

        /// <summary>
        /// Propiedad de lectura y escritura del atributo partidos jugados
        /// </summary>
        public int PJ
        {
            get 
            {
                return this.partidosJugados; 
            }
            set 
            {
                if (value >= 0)
                {
                    this.partidosJugados = value;
                }
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo partidos perdidos
        /// </summary>
        public int PP
        {
            get 
            {
                return this.partidosPerdido; 
            }
            set 
            {
                if (value >= 0)
                {
                    this.partidosPerdido = value;
                }
            }
        }
        /// <summary>
        /// Propiedad de lectura y escritura del atributo puntuacion
        /// </summary>
        public int Puntuacion
        {
            get 
            {
                return this.puntuacion; 
            }
            set 
            {
                if (value >= 0)
                {
                    this.puntuacion = value;
                }
            }
        }
        /// <summary>
        /// Propiedad de lectura Tipo retornara  Name del Type de la instancia.
        /// </summary>
        /// DEBIAS PONER.NAME 
        public string Tipo
        {
            get { return this.GetType().Name; }
           
        }


        #endregion

        #region  CONSTRUCTORES


        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }
        #endregion

        #region METODOS

        public abstract int GetDificultad();
        protected virtual string  MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            return sb.ToString();
        }
        //FALTÓ public 
        public static bool JugarPartido(Equipo equipoA,Equipo equipoB)
        {
           // equipoA.Equals(equipoB);
            if (equipoA is not null && equipoB is not null && equipoA.Equals(equipoB))
            {
                    equipoA.PJ += 1;
                    equipoB.PJ += 1;
                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.Puntuacion += 3;
                    //faltó esto
                    equipoA.PG += 1;
                    equipoB.PP += 1;
                }
                if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.Puntuacion += 3;
                    //faltó esto
                    equipoA.PG += 1;
                    equipoB.PP += 1;
                }
                else 
                {
                    equipoB.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                    //faltó esto
                    equipoA.PE += 1;
                    equipoB.PE += 1;

                }
                return true;
            }
            return false;
            
        }



        #endregion



        #region  SOBRECARGA
        public override bool Equals(object obj)
        {
            //faltó validar que no sea null
            return this.GetType() == obj.GetType();
        }

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Equals(equipoB) && equipoA.Nombre == equipoB.Nombre;

        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }
        #endregion


    }
}
