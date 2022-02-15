using System;

namespace Polimorfismo
{
    /* 
     É um recurso que permite a crição de classes derivadas da classe base como genéricaas,
     assim que permite que consigamos reutilizar / genralizar nosso metodos (novamente).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Biblioteca.Derivada.Moto moto = new Biblioteca.Derivada.Moto();
            MoverVeiculo(moto);

            Biblioteca.Derivada.Carro carro = new Biblioteca.Derivada.Carro();
            MoverVeiculo(carro);

            Biblioteca.Derivada.Onibus onibus = new Biblioteca.Derivada.Onibus();
            MoverVeiculo(onibus);
            
        }

        public static void MoverVeiculo(Biblioteca.Veiculo veiculo)
        {
            veiculo.Mover();
        }
        
    }
}
