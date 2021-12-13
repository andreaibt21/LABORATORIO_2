using System;
using System.Text;
namespace Entidades
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;



        public AutoF1()
        {

        }
        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.puntoPartida = puntoPartida;
            this.velocidad = velocidad;
        }
        #region Propiedades
        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }
        public int Posicion
        {
            get { return this.posicion; }
            set { this.posicion = value; }
        }
        public int PuntoPartida
        {
            get { return this.puntoPartida; }
            set { this.puntoPartida = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = value; }
        }
        public int UbicacionEnPista
        {
            get { return PuntoPartida; }
            set { this.velocidad = value; }
        }
        #endregion

        /// <summary>
        /// sumara el atributo velocidad a puntoPartida
        /// </summary>
        public void Acelerar(){

            this.PuntoPartida += velocidad;
        }
        /// <summary>
        /// , el cual expondrá la escudería y la posición del vehículo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";

        }









    }//fin class
}
