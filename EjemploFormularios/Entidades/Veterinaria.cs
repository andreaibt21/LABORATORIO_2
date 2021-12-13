using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Veterinaria
    {

        private Animal mascota;

        public Veterinaria(string nombre)
        {
            this.mascota = new Animal(nombre);
        }

        public Animal Mascota
        {
            get 
            {
                return mascota;
            }
        }


    }
}
