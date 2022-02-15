using System;

namespace Modulo.Orientado.Objeto
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorPoupancaTexto, nome;
            float valorPoupanca;
            Console.WriteLine("Informe o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o valor que você possui em conta Poupanca: ");
            valorPoupancaTexto = Console.ReadLine();
            valorPoupanca = float.Parse(valorPoupancaTexto);

            if (valorPoupanca >= 100000)
            {
                Console.WriteLine(nome + ", Você é um cliente Personalizado, sua conta possui uma " +
                    "taxa de juros diferenciada! Seu saldo é de:" + valorPoupanca.ToString("C"));
            }
            else if (valorPoupanca >= 50000)
            {
                Console.WriteLine(nome + ", Você é um cliente especial, Sua taxa de juros é de 1.1 ao mês. Seu Saldo é de:" +
                    valorPoupanca.ToString("C"));
            }



            else
            {
                Console.WriteLine(nome + ", Você possui uma conta básica com taxa de juros normal. Seu Saldo é de :" + valorPoupanca.ToString("C"));
            }
        }
    }
}
