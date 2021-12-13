using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ParcialMascotas
{
    public class Grupo
    {
       public  enum TipoManada { Unica, Mixta }

        private List<Mascota> manada;
        private string nombre;
        private static TipoManada tipo;


        private Grupo(){
            this.manada = new List<Mascota>();
        }
         static Grupo() {
            Grupo.tipo = TipoManada.Unica;
        
        }
        public Grupo(string nombre): this()
        {
            this.nombre = nombre;
         
        }
        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
            Grupo.Tipo = tipo;
        }

        public static TipoManada Tipo
        {
            set {
                Grupo.tipo = value; 
            }
        }


        public static bool operator ==(Grupo e, Mascota j)
        {
            if (e.manada.Count != 0 && j is not null)
            {
                foreach (Mascota item in e.manada)
                {
                    j.Equals(item);
                    return true;
                }
            }
            else 
            {
                return false;
            }
            return false;

        }
        public static bool operator !=(Grupo e, Mascota j)
        {

            return !(e == j);
        }


        public static Grupo operator +(Grupo e, Mascota j)
        {

            if (e == j)
            {
                Console.WriteLine($"Ya está el '{j}' en el grupo");
            }
            else { 
                e.manada.Add(j);
            
            }
            return e;
        }
        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (e is not null && j is not null)
            {
                if (e == j)
                {
                    e.manada.Remove(j);
                }
            }
            return e;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  **{this.nombre}**");
            sb.AppendLine("Integrantes");

            foreach (Mascota item in this.manada)
            {
                sb.AppendLine($"{item.ToString()}");

            }



            return  sb.ToString();
        }




    }//end class
}
