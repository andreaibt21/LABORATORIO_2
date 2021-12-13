using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Partido
    { 
        private Equipo equipoLocal;
        private Equipo equipoVisitante;
        private int golesLocal;
        private int golesVisitante;
        private bool partidoJugado;
        private Random random;
        private EResultado resultadoEquipoLocal;

        public Partido(Equipo equipoLocal, Equipo equipoVisitante)
        {
            this.equipoLocal = equipoLocal;
            this.equipoVisitante = equipoVisitante;
        }

        private Partido() 
        {
            this.random = new Random();
        }

        public void SimularPartido()
        {
            this.partidoJugado = true;
            this.golesLocal = random.Next(0, 15);
            this.golesVisitante = random.Next(0, 15);

            if (this.golesLocal > golesVisitante)
            {
                this.resultadoEquipoLocal = EResultado.Victoria;
                equipoLocal.Estadistica.Actualizar(EResultado.Victoria, golesLocal, golesVisitante);
                equipoVisitante.Estadistica.Actualizar(EResultado.Derrota, golesVisitante, golesLocal);
            }
            else if (this.golesLocal == golesVisitante)
            {
                this.resultadoEquipoLocal = EResultado.Empate;
                equipoVisitante.Estadistica.Actualizar(EResultado.Empate, golesVisitante, golesLocal);
            }
            else
            {
                this.resultadoEquipoLocal = EResultado.Derrota;
                equipoVisitante.Estadistica.Actualizar(EResultado.Victoria, golesVisitante, golesLocal);
            }
            equipoLocal.Estadistica.Actualizar(resultadoEquipoLocal, golesLocal, golesVisitante);

        }







    } //fin class partido
}
