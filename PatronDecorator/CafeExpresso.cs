using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDecorator
{
    public class CafeExpresso : BebidaComponent
    {
        public override double Costo => 12;

        public override string Description => "Café expresso";
    }
}
