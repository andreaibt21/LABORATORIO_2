using System;
using System.Text;

namespace CentralTelefonica
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada { Local, Provincial, Todas };
       

        #region PROPIEDADES
        public float Duracion 
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        
        public abstract float CostoLlamada { get; }
        
        #endregion

        #region METODOS
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }


        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" Duracion: {this.Duracion}");
            sb.AppendLine($" Numero de Destino: {this.NroDestino}");
            sb.AppendLine($" Numero de Origen: {this.NroOrigen}");
            return sb.ToString();

        }
        
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if ( llamada1.duracion > llamada2.duracion)
            {
                return -1; 
            }
            if (llamada1.duracion < llamada2.duracion)
            {
                return 1;
            }           
                return 0;
            

        }

        #endregion

        #region SOBRECARGA
        /*
         El operador == comparará dos llamadas y retornará true si las llamadas son del mismo tipo
        (utilizar método Equals, sobrescrito en las clases derivadas) y los números de destino y
        origen son iguales en ambas llamadas.
         */
        public static bool operator ==(Llamada l1, Llamada l2 )
        {
            return l1.Equals(l2);
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return l1==l2;
        }
        #endregion
    }//fin class LLamada
}
