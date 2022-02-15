using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Biblioteca
{
    class Patins : Veiculo
    {
        public void Mover()
        {
            velocidadeMaxima = "5km";
            qtdPassageiros = 1;
            marca = "Caloy";

            Console.WriteLine(base.velocidadeMaxima = "1km");


        }
    }
}
