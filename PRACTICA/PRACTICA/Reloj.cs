using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PRACTICA
{
    public class Reloj
    {
        public int hora;
        public int minuto;
        public int segundos;

        public delegate void DelegadoReloj(Reloj reloj);
        public event DelegadoReloj cambioElTiempo;

        public void Ejecutar()
        {
            while (true)
            {
                Thread.Sleep(1000);
                DateTime time = DateTime.Now;
                if (time.Second != this.segundos )
                {
                    if (cambioElTiempo is not null)
                    {
                        cambioElTiempo.Invoke(this);
                    }
                }
                segundos = time.Second;
                hora = time.Hour;
                minuto = time.Minute;
            }
        }
    }
}
