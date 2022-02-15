using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Biblioteca
{
   public class Veiculo
    {
        public string marca;
        public string modelo;
        public int qtdPassageiros;
        public int ano;
        public string velocidadeMaxima = "0 km"; 

        public virtual void Mover()
        {
            velocidadeMaxima = "250";
            Console.WriteLine("A Velocidade Maxima do "+ marca + "é: " + velocidadeMaxima);
        }
    }
}
