using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gripe : Microrganismo
    {
        public Gripe(string nombre, ETipo tipo, EContagiosidad contagiosidad) : base(nombre, tipo, contagiosidad)
        {
        }

        public override long IndiceDeContagios
        {
            get { return this.contador * 5; }
        }
    }
}
