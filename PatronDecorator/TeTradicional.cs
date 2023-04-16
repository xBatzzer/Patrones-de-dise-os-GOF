using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class TeTradicional : BebidaComponent
    {
        public override double Costo => 8;

        public override string Description => "Té tradicional";
    }
}
