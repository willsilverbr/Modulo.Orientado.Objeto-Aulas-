using System;
using Heranca.Biblioteca;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Moto moto = new Moto();
            Veiculo veiculo = new Veiculo();
            Patins patins = new Patins();

            Console.WriteLine("Informe a Marca do Carro: ");
            carro.modelo =  Console.ReadLine ();

            Console.WriteLine("Informe a Marca da Moto: ");
            moto.modelo = Console.ReadLine();

            Console.WriteLine("Informe a Marca do Veiculo: ");
            veiculo.modelo = Console.ReadLine();
     
            Console.WriteLine(" Modelo do Carro: " + carro.modelo + "" +
                              "\n Modelo da Moto: " +  moto.modelo + "" +
                              "\n Modelo do Veiculo: "+ veiculo.modelo);

           

        }
    }
}
