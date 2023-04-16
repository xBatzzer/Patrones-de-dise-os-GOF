using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter
{
    public class MotorElectrico
    {
        bool _conectado, _activo, _moviendo;
        
        public void Conectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Imposible conectar un motor eléctrico ya conectado!");
            }
            else
            {
                _conectado = true;
                Console.WriteLine("Motor conectado!");
            }
        }

        public void Activar()
        {
            if (!_conectado)
            {
                Console.WriteLine("Imposible activar un motor no conectado!");
            }
            else
            {
                _activo = true;
                Console.WriteLine("Motor activado!");
            }
        }

        public void Desactivar()
        {
            if (_conectado && _activo)
            {
                _activo = false;
            }
            else
            {
                Console.WriteLine("No se puede desactivar un motor que no está activo");
            }
        }

        public void Mover()
        {
            if (_conectado && _activo)
            {
                _moviendo = true;
                Console.WriteLine("Moviendo vehículo con motor eléctrico");
            }
            else
            {
                Console.WriteLine("El motor debe estar conectado y activado!");
            }
        }

        public void Parar()
        {
            if (_moviendo)
            {
                _moviendo = false;
                Console.WriteLine("Parando vehículo con motor eléctrico");
            }
            else
            {
                Console.WriteLine("Imposible parar un motor que no esté en movimiento");
            }
        }
       
        public void Desconectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Motor desconectado");
            }
            else
            {
                Console.WriteLine("No se puede desconectar un motor que no está activo");
            }
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando las baterias!");
            }
            else
            {
                Console.WriteLine("No se puede enchufar un motor eléctrico inactivo");
            }
        }

    }
}
