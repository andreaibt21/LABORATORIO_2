using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

    /*
   
        ●	InfectarPoblacion:
        o	Controlará que su argumento sea del tipo T.
        o	Establecerá la enfermedad a simular (cargar el atributo de clase), e iniciará el día en 1.
        o	Calculará mediante la propiedad IndiceDeContagios cuantos infectados hay.
        o	Los infectados no podrán superar la cantidad de población, solo igualarla.
        o	Se informará mediante el evento InformeDeAvance el estado de la simulación.
        o	Se incrementará el día, se hará un sleep de 0.75 segundos y se iterará hasta completar la infección 
            de toda la población.
        o	Una vez finalizado el proceso anterior, se deberá informar mediante FinalizaSimulacion que toda
            la población ha sido infectada.
        o	Tener en cuenta no llamar a eventos que no tienen suscriptores.

     */

    /// <summary>
    ///  ●	La clase es estática.
    ///  ●	Su tipo genérico deberá tener una restricción de tipo: deberá ser Microorganismo o uno de sus derivados.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class GrupoDePrueba <T> where T : Microrganismo
    {
        private static T enfermedad;
        private static long poblacion;



        public static long Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
        }



        /// <summary>
        /// ●	Por defecto, su población será de 10000000.
        /// </summary>
        static GrupoDePrueba()
        {
            poblacion = 1000;
        }

        public delegate void AvanceInfectados(int dia, long infectados);
        public delegate void FinInfectacion();

        public static AvanceInfectados delAvanceInfectados;
        public static FinInfectacion delFinInfectacion;
        public static event FinInfectacion FinalizaSimulacion;
        public static event AvanceInfectados InformeDeAvance;
        public static void InfectarPoblacion(object obj)
        {
            T enfermedadIngresada = obj as T;
            if (enfermedadIngresada is not null)
            {
                int dia = 1;
                GrupoDePrueba<T>.enfermedad = enfermedadIngresada;
                if (InformeDeAvance != null && FinalizaSimulacion != null)
                { 
                
                    long contagiados = GrupoDePrueba<T>.enfermedad.IndiceDeContagios;
                    //primera cuenta
                    while (contagiados <= Poblacion)
                    {         //Se iterara hasta contagiarse toda la poblacion

                        InformeDeAvance.Invoke(dia++, contagiados);
                        Thread.Sleep(750);
                        contagiados *= enfermedadIngresada.IndiceDeContagios;
                    }
                    //Una vez contagiada toda la poblacion, se finaliza la simulacion

                    FinalizaSimulacion.Invoke();
                }

            }
        }

        
    }
}
