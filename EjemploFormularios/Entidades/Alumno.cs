using System;

namespace Entidades
{
    public class Alumno
    {

        private string nombre;
        private string direccion;
        private string dni;

        public Alumno(string dni, string nombre, string direccion)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.direccion = direccion;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string DNI
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public override string ToString()
        {
            return $"DNI: {dni}- NOMBRE:{nombre}  - DIRECCION: {direccion}";
        }


    }
}
