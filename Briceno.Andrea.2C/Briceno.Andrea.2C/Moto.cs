﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Briceno.Andrea._2C
{
    sealed class Moto : Vehiculo
    {
        public enum ETipo { Ciclomotor, Scooter, Sport };
        private ETipo tipo;
        private static double valorHora;
        static Moto()
        {
            Moto.valorHora = 100;
        }

        public Moto(string patente, DateTime horaIngreso, ETipo tipo)
          : base(horaIngreso, patente)
        {
            this.tipo = tipo;
        }
        

        public override double CostoEstadia
        {
            get
            {
                return this.CargoDeEstacionamiento();
            }
        }
        public static double ValorHora
        {
            set
            {
                if (value > 0)
                {
                    Moto.valorHora = value;
                }
            }
        }
        public override string Descripcion
        {
            get
            {
                return this.tipo.ToString();
            }
        }

        protected override double CargoDeEstacionamiento()
        {
            return base.CargoDeEstacionamiento() * Moto.valorHora;
        }       


    }//fin class Moto

}
