using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralTelefonica
{
    public abstract class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        #region CONSTRUCTOR Y PROPIEDADES

       public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa ):this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region METODOS

        /// <summary>
        /// Este método recibe un Enumerado TipoLlamada y retornará
        /// el valor de lo recaudado, según el criterio elegido(ganancias por las llamadas del tipo Local,
        /// Provincial o de Todas según corresponda).
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float gananciaLocal = 0;
            float gananciaProvincial = 0;


            foreach ( Llamada llamada in this.Llamadas)
            {

                if ( llamada is Local)
                {
                    gananciaLocal += ((Local)llamada).CostoLlamada;
                }
                if (llamada is Provincial)
                {
                    gananciaProvincial += ((Provincial)llamada).CostoLlamada;
                }
            }

            switch (tipo)
            {
                case Llamada.TipoLlamada.Local:
                    {
                        return gananciaLocal;
                    }
                case Llamada.TipoLlamada.Provincial:
                    {
                        return gananciaProvincial;
                    }
                default:
                    {
                        return gananciaLocal + gananciaProvincial;
                    }
            }

        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"La razon social es: ***** {this.razonSocial} *****");
            sb.AppendLine($"La ganancia total es : {this.GananciasPorTotal}");
            sb.AppendLine($"La ganancia local es : {this.GananciasPorLocal}");
            sb.AppendLine($"La ganancia provincial es : {this.GananciasPorProvincial}");
            sb.AppendLine("-------------------------------------------------------\n\n***** Listado de llamadas *****");

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                sb.AppendLine(llamada.Mostrar());
            }
            
            return sb.ToString();

        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        #endregion

    }// fin class centralita
}
