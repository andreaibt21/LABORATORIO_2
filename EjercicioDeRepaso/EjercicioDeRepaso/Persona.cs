using System;
using System.Collections.Generic;

namespace EjercicioDeRepaso
{
    public abstract class Persona
    {
        protected bool asistir;
        protected int id;
        protected string nombre;
        protected List<Materias> materias;

        protected Persona(bool asistir, string nombre, int id)
        {
            this.asistir = asistir;
            this.nombre = nombre;
            this.id = id;
        }

        protected Persona(bool asistir, string nombre, int id, List<Materias> materias)
            :this(asistir,nombre,id)
        {
            this.materias = materias;
        }

        public bool AsistirAClase()
        {
            return this.asistir = true;
        }

        abstract protected string PrepararParcial();


    }
}
