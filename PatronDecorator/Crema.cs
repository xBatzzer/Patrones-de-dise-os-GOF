using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class Crema : AgregadoDecorator
    {
        public Crema(BebidaComponent bebida) : base(bebida) { }

        public override double Costo => _bebida.Costo + 4;
        public override string Description => string.Format($"{_bebida.Description}, Crema");
    }
}
