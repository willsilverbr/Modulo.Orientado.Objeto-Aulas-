using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Carro
    {
        public string marca, modelo;
        public int ano; 
        public Carro()
        {
            marca = "Fiat";
            modelo = "Palio"; 

        }
        public Carro (String marca, string modelo, int Ano)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = Ano; 
        }
    }
}
