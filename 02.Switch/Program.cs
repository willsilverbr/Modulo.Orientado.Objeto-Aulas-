using System;

namespace _02.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; 
            Console.WriteLine("Digite o número do menu de acesso:" +
                "              Para Acessar a Home- 1, " +
                "              Para Acessar o Perfil-2 " +
                "              Contatos-3 " +
                "              Sair-4.");

            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 2:
                    Console.WriteLine("Você está na página de perfil. ");
                    break;

                case 1:
                    Console.WriteLine("Você está HomePage");
                    break;

                case 3:
                    Console.WriteLine("Você está na página de contatos");
                    break;

                case 4:
                    Console.WriteLine("Você Saiu");
                    break;

                default:
                    Console.WriteLine("Digite um valor entre 1 - 4");
                    break; 

            }
        }
        
    }
}
