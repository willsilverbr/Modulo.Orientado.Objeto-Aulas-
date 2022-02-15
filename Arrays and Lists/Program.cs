using System;
using System.Collections.Generic;

namespace Arrays_and_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> marcas = new List<string>();
            marcas.Add("Fiat");
            marcas.Add("\nRenault");
            marcas.Add("\nPegout");

            Console.WriteLine(marcas[0]);
            Console.WriteLine(marcas[2]);

            string[] nomes = { "Will", "Ana", "Pedro", "Falso" };

            foreach (string nome in nomes)
            {


                if (nome == "Pedro")
                {
                    continue;
                }
                else if (nome == "Falso")
                {
                    Console.WriteLine("\nNome deu Falso.Saida!");
                    break;
                }

                Console.WriteLine("\nNomes:" + nome);

                /*Da par armazenar chave e o valor de cada item*/
                Dictionary<string, int> dicionario = new Dictionary<string, int>();
                dicionario.Add("\nValor1", 128);
                dicionario.Add("\nValor2", 50);
                dicionario.Add("\nValor3", 10); 
            }
        }
    }
}
