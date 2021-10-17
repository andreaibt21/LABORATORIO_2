using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public class Provincial : Llamada
    {
        public enum Franja { Franja_1, Franja_2, Franja_3 }
        protected Franja franjaHoraria;


        #region CONSTRUCTOR Y  PROPIEDADES 
        public Provincial(Franja miFranja, Llamada llamada)
            : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino)
        {

        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino) 
            : base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }

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
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return this.Duracion * (float)0.99;
                
                case Franja.Franja_2:
                    return this.Duracion * (float)1.25;
              
                case Franja.Franja_3:
                    return this.Duracion * (float)0.66;
            }
            return 0;
        }



        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($" { base.Mostrar() }");
            sb.AppendLine($" Franja: {this.franjaHoraria}");
            sb.AppendLine($" Costo: {this.CostoLlamada}");
            return sb.ToString();

        }
        #endregion


    }//fin de clase 
}
