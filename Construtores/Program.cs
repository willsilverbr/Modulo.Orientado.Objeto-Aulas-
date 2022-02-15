using System;

namespace Construtores
{
    class Program
    {
        /*É a Forma de se Instanciar um objeto, ou seja é um metodo construtor*/
        static void Main(string[] args)
        {
            Carro carro = new Carro(); 


            Carro carro2 = new Construtores.Carro("Fiat", "Uno", 2010);            
        }
    }
}
