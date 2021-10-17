using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRepaso
{
    public class Alumno : Persona
    {
        public int anoDeInscripcion;

        public Alumno(bool asistir, string nombre, int id, List<Materias> materias, int anoDeInscripcion) 
            : base(asistir, nombre, id, materias)
        {
            this.anoDeInscripcion = anoDeInscripcion;
        }
        

       
        protected override string PrepararParcial()
        {
            return "Está estudiando";
        }
    }
}
