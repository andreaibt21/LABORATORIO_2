using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EjercitoImperial
    {
        private int capacidad;
        private List<Trooper> troopers;

        public List<Trooper> Troopers {
            get
            {
               return troopers;
            }
        }

       private EjercitoImperial()
       {
            troopers = new List<Trooper>();
       }

        public EjercitoImperial(int capacidad): this()
        {
            this.capacidad = capacidad;

        }


        /// <summary>
        /// El operador + deberá ser capaz de agregar un Trooper al Ejército Imperial.
        /// a.La capacidad se utilizará para dar un límite a la cantidad de soldados de dicho ejército.
        /// b.Si hay lugar, se agregará al nuevo soldado y se retornará el ejército modificado
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns></returns>
        public static EjercitoImperial operator +(EjercitoImperial ejercito, Trooper soldado)
        {

            if (ejercito is not null && soldado is not null && ejercito.troopers.Count <= ejercito.capacidad)
            {
                ejercito.troopers.Add(soldado);
                return ejercito;
            }

            return ejercito;

        }

        /// <summary>
        /// El operador – deberá ser capaz de sacar a un Trooper del Ejército Imperial.
        ///a.Se buscará el primer Trooper del mismo tipo(TYPE) para ser removido.
        ///b.Sólo se quitará la primer aparición de un Trooper que coincida.
        ///c.Se retornará el ejército modificado.
        /// </summary>
        /// <param name="ejercito"></param>
        /// <param name="soldado"></param>
        /// <returns></returns>
        public static EjercitoImperial operator -(EjercitoImperial ejercito, Trooper soldado)
        {

            if (ejercito is not null && soldado is not null )
            {

                foreach (Trooper item in ejercito.troopers)
                { 
                   if (item.Tipo == soldado.Tipo)
                    {

                        ejercito.troopers.Remove(soldado);
                        return ejercito;
                    }
                   
                }
            }

            return ejercito;
        }
    }//fin clase 
}
