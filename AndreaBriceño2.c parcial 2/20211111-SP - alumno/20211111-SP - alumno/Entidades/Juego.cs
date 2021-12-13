using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{

    public delegate object sender();
    public delegate short movimiento();
   
    public class Juego
    {
        private static short velocidad;
        private short ubicacion;
        private object controlVisual;

      



        Juego()
        {
            Juego.velocidad = 8;
        }
        public Juego(short ubicacion, object objetoVisual) : this()
        {
            this.ubicacion = ubicacion;
            this.controlVisual = objetoVisual;

        }
        public short Velocidad
        {
            get { return Juego.velocidad; }
            set { Juego.velocidad = value; }
        }


        public short Ubicacion
        {
            get { return this.ubicacion; }
            set { this.ubicacion = value; }
        }

        [System.Text.Json.Serialization.JsonIgnore]
        public object ControlVisual
        {
            get
            {
                return this.controlVisual;
            }
            set
            {
                this.controlVisual = value;
            }
        }

        public short Avanzar()
        {
            this.ubicacion += velocidad;
            return this.ubicacion;
        }

        /// <summary>
        /// Simular la animación del Carrusel
        /// </summary>
        public void IniciarCarrusel()
        {
            do
            {
             //   movimiento mo = InformarAvance;

                System.Threading.Thread.Sleep(60 + Juego.velocidad);
            } while (true);
        }

        /// <summary>
        /// . Agregar el evento InformarAvance en la clase Juego.
        ///   a.Movimiento corresponderá con la nueva ubicación del elemento
        ///   b.Sender será si mismo, this
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public object InformarAvance(object sender , EventArgs e )
        {
            
            return this.Avanzar();
        }

        //CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        //CancellationToken cancellationToken = cancellationTokenSource.Token;
      
        //    cancellationTokenSource.Cancel();


    }
}
