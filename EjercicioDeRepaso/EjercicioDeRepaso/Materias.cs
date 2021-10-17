using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDeRepaso
{
    public class Materias
    {
        private string nombre;
        private int cargaHoraria;
        private bool cuatrimestral;

        public Materias(string nombre, int cargaHoraria, bool cuatrimestral)
        {
            this.nombre = nombre;
            this.cargaHoraria = cargaHoraria;
            this.cuatrimestral = cuatrimestral;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
          
        }
        public int CargaHoraria
        {
            get
            {
                return this.cargaHoraria;
            }
           
        }
        public bool Cuatrimestral
        {    
            get 
            {
                return this.cuatrimestral; 
            }
            set 
            { 
                this.cuatrimestral = value;
            }
        }
    }
}
