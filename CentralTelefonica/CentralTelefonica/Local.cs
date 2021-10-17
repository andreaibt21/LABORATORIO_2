using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Local : Llamada
    {
        /*
         Local:
            e. Heredará de Llamada.
            f. Método Mostrar expondrá, además de los atributos de la clase base, la propiedad
            CostoLlamada. Utilizar StringBuilder.
            g. CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo
            de la misma.
            h. La propiedad CostoLlamada retornará el precio, que se calculará en el método
            CalcularCosto.
         */
        protected float costo;
                                            
        public Local(Llamada llamada, float costo) 
        :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo )
        {
            
        }

        public Local(string origen, float duracion, string destino, float costo) : base(duracion,destino,origen)
        {
            this.costo = costo;
        }

        #region PROPIEDADES 
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion
        
        
        #region METODOS 
        private float CalcularCosto()
        {
            return this.Duracion * this.costo;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" { base.Mostrar() }");
            sb.AppendLine($" Costo: {this.CostoLlamada}");
            return sb.ToString();

        }
        #endregion




    }// 
}
