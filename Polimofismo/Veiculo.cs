using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Biblioteca
{
    /* 
     É um recurso que permite a crição de classes derivadas da classe base como genéricaas,
     assim que permite que consigamos reutilizar / genralizar nosso metodos (novamente).
     */
    class Veiculo
    {
        public string marca;
        public string modelo;
        public string ano;

        public virtual void Mover()
        {
            Console.WriteLine("Veiculo se movendo!");
        }
    }
}
