using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRepaso
{
    public class Docente : Persona
    {
        public int Antiguedad;
        public bool esSoloDocente;
        public int sueldo;

      
        public Docente(bool asistir, string nombre, int id)
            :base(asistir,nombre, id) 
        { }

        public Docente(bool asistir, string nombre, int id, List<Materias> materias, int antiguedad, bool esSoloDocente, int sueldo) 
            : this(asistir, nombre, id)
        {
            Antiguedad = antiguedad;
            this.esSoloDocente = esSoloDocente;
            this.sueldo = sueldo;
        }

        public void AgregarMaterias(Materias materia)
        {
            this.materias.Add(materia);
        }

        protected override string PrepararParcial()
        {
            return "Está haciendo el parcial";

        }
    }
}
