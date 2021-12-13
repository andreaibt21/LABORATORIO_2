using System;

namespace Entidades
{
    public abstract class Deportista
    {
        private int cantidadPartidos;
        private int edad;
        private string nombreApellido;

        protected Deportista(string nombreApellido, int edad, int cantidadPartidos)
        {
            this.cantidadPartidos = cantidadPartidos;
            this.edad = edad;
            this.nombreApellido = nombreApellido;
        }

        public int CantidadPartidos
        {
            get { return this.cantidadPartidos; }
            set { this.cantidadPartidos = value; }
        }
        public int Edad
        {
            get { return this.edad; }
            set { this.edad = value; }
        }
        public string NombreApelido
        {
            get { return this.nombreApellido; }
        }


    }// fin de class
}
