using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetidores;
        private string nombre;
        private List<Equipo> equipos;

        #region CONSTRUCTORES

        public Competencia(string nombre, int cantidadCompetidores)
        {
            this.equipos = new List<Equipo>();
            this.nombre = nombre;
            this.cantidadCompetidores = cantidadCompetidores;

        }

        private Competencia(string nombre)
            :this(nombre, 5)
        {

        }

        #endregion


        #region PROPIEDADES



        public int CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        /// <summary>
        /// Propiedad de lectura del atributo Equipo
        /// </summary>        
        public List<Equipo> Equipos
        {
            get { return this.equipos; }
        }

        // FALTÓ VALIDAR
        /// <summary>
        /// Propiedad de lectura y escritura del atributo nombre
        /// </summary>
        public string Nombre
        {
            get 
            {
                return this.nombre; 
            }
            set 
            { 
                 if(!String.IsNullOrEmpty(value))
                {
                    this.nombre = value; }

                }
        }


        #endregion

        #region  SOBRECARGAS

        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }
        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            if (equipo is not null && torneo.equipos.Count != 0)
            {
                foreach (Equipo item in torneo.equipos)
                {
                    if (item == equipo)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        /// <summary>
        /// Sobrecargar el operador + para agregar un Equipo a la competencia.
      ///  Solo se podrá agregar si este no se encuentra en esta y la competencia aun dispone de capacidad.h.
        /// </summary>
        /// <param name="torneo"></param>
        /// <param name="equipo"></param>
        /// <returns></returns>
        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {

           // if (torneo != equipo && torneo.CantidadCompetidores != 0 )
                if (torneo != equipo && torneo.CantidadCompetidores > torneo.equipos.Count )
            {
           
                torneo.equipos.Add(equipo);
                

            }
            return torneo;
        }
        /// <summary>
        /// MostrarTorneo será de Clase, recibe una competencia y expondrá los datos de la competencia en conjunto con la lista de competidores.
        /// </summary>
        /// <param name="torneo"></param>
        /// <returns></returns>
        public static string MostrarTorneo(Competencia torneo)
        {

                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Nombre competencia : {torneo.Nombre}");
                sb.AppendLine($"Cantidad competidores : {torneo.CantidadCompetidores}");
                foreach (Equipo item in torneo.equipos)
                {
                    sb.AppendLine(item.ToString());
                }
                    return sb.ToString();
        }
        #endregion




    }
}
