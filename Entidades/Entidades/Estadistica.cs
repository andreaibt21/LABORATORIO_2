using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estadistica
    {
        private int empatados;
        private int ganados;
        private int golesEnContra;
        private int golesFavor;
        private int partJugados;
        private int perdidos;
        private int puntos;

        public int Empatados
        { get { return this.empatados; }
            set { this.empatados = value; }
        }
        public int Ganados
        {
            get { return this.ganados; }
            set { this.ganados = value; }
        }
        public int GolesEnContra
        {
            get { return this.golesEnContra; }
            set { this.golesEnContra = value; }
        }
        public int GolesFavor
        {
            get { return this.golesFavor; }
            set { this.golesFavor = value; }
        }
        public int PartJugados
        {
            get { return this.partJugados; }
            set { this.partJugados = value; }
        }
        public int Perdidos
        {
            get { return this.perdidos; }
            set { this.perdidos = value; }
        }
        public int Puntos
        {
            get { return this.puntos; }
            set { this.puntos = value; }
        }

        public Estadistica(){}

        public void Actualizar(EResultado resu, int GolFav, int golNeg) 
        {
            switch (resu) 
            {
                case EResultado.Victoria:
                    this.Ganados += 1;
                    this.Puntos += 3;
                    break;
                case EResultado.Empate:
                    this.Puntos += 1;
                    this.Empatados += 1;
                    break;
                case EResultado.Derrota:
                    this.Perdidos += 1;
                    this.Puntos += 0;
                    break;
            }
            this.GolesEnContra += GolFav;
            this.GolesFavor += golNeg;
            this.PartJugados += 1;
          

        }



    }// fin class estadistica
}
//3 2 1 