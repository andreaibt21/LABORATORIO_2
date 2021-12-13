using System;
using System.Threading;

namespace Ejercico_67_Temporizador
{
    public class Temporizador
    {

        private Thread hilo;
        private int intervalo;

        public bool Activo { get; set; }
        public int Intervalo { get; set; }


    }//fin class
}
