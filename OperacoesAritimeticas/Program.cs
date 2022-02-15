using System;

namespace OperacoesAritimeticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma que retorna String concatenada:" + 2 + 2);
            Console.WriteLine("\nSoma que retorna inteiro:" + (2 + 2));
            Console.WriteLine("\nO mesmo vale para as demais como subtração, " +
                              "multiplicação e divisão \n");

            Console.WriteLine("Modulo/Resto:" + (8 % 2));
            Console.WriteLine("\nModulo/Resto:" + (8 % 3));

            //Operadores de atribuição exemplo
            int a = 10;
            a += 10; //a = a + a 
            //O mesmo vale para os outros operadores
            Console.WriteLine("A soma é "+ a);

            if (a == 10 && 10 >9)
            {
                Console.WriteLine("\nVerdadeiro");
            }
            else if (a !=10 | a == 20)
            {
                Console.WriteLine("\nFalso");
            }
            
            //Operadores Lógicos
            // And/Or 

            

        }
    }
}
