using System;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = { "Will", "Ana", "Pedro", "Falso" };

            foreach (string nome in nomes)
            {
               

                if (nome == "Pedro")
                {
                    continue; 
                }
                else if (nome == "Falso")
                {
                    Console.WriteLine("Nome deu Falso.Saida!");
                    break;
                }
                
                Console.WriteLine("Nomes:" + nome);
            }
        }
    }
}
