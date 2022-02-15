using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Biblioteca.Derivada
{
    class Carro : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Carro se movendo!");
        }
    }
}
