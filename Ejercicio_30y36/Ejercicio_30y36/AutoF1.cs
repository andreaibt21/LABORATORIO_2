using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30y36
{
    public class AutoF1
    {


        private short cantidadCombustible;
        private bool enCompetencia;
        private short vueltasRestantes;
        private string escuderia;
        private short numero;

        public AutoF1(string escuderia, short numero)
        {

            this.escuderia = escuderia;
            this.numero = numero;
            this.cantidadCombustible = 0;
            this.vueltasRestantes = 0;
            this.enCompetencia = false;

        }

        public short CantidadCombustible
        {
            get
            {
                return cantidadCombustible;
            }
            set
            {
                cantidadCombustible = value;
            }
        }
        public bool EnCompetencia
        {
            get
            {
                return enCompetencia;
            }
            set
            {
                enCompetencia = value;
            }
        }
        public short VueltasRestantes
        {
            get
            {
                return vueltasRestantes;
            }
            set
            {
                vueltasRestantes = value;
            }
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("En competencia: " + EnCompetencia);
            sb.AppendLine("cantidad Combustible: " + CantidadCombustible);
            sb.AppendLine("Vueltas Restantes: " + VueltasRestantes);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Numero: " + numero);


            return sb.ToString();
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return ( (a1.numero == a2.numero) && (a1.escuderia == a2.escuderia) );
        }
        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }



    }
}
