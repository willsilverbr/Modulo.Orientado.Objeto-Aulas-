using System;

namespace ManipulandoTextos
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = " Olá texto" +
                            "texto feliz texto" +
                            "textotextotextotextotextotexto      ";

            string palavra = "feliz";

            Console.WriteLine("Tamanho do texto " + texto.Length);
            Console.WriteLine("Localizar primeiro texto : " + texto.IndexOf(palavra));
            Console.WriteLine("Localizar ultimo texto : " + texto.LastIndexOf(palavra));


            //Substituir um determinado texto
            string cpf = "123.456.789-98";
            string cpfSemPonto = "12345678998";
            
            
            string textoSub = cpf.Replace(".", ""); //Para retirar apenas o ponto
            Console.WriteLine(textoSub);

            //Verificar texto
            string texto2 = "Olá Amigos!";

            Console.WriteLine("Verifica a existencia no inicio: " + texto2.StartsWith("Olá"));
            Console.WriteLine("Verifica a existencia no final: " + texto2.EndsWith("!")); Console.WriteLine("");
            Console.WriteLine("Verifica a existencia no inicio: " + texto2.Contains(" "));


            //string format para concatenar uma frase
            string nome = "will";
            string textoFormatado = string.Format("Olá {0} Bem Vindo! Boa {1}", nome, "Sorte!\n");
            Console.WriteLine(textoFormatado);

            //MudarCaracter 
            Console.WriteLine(nome.ToUpper()); //para maiusculo
            Console.WriteLine(nome.ToLower()); //Para Minusculo

            //Remover Espaços em Branco do inicio, meio ou do final do texto
            Console.WriteLine(texto.TrimEnd());
            Console.WriteLine(texto.TrimStart());
            Console.WriteLine(texto.Trim());

            // dividindo Texto em arrays
            string nomes = "João, Maria, Ana, William, Tiago e Paulo.";

            string [] separador = {", ", " e " };
            string[] nomesArray = nomes.Split(separador, StringSplitOptions.None);

            foreach (string nome1 in nomesArray)
            {
                Console.WriteLine("\n"+nome1);
            }

            //Obter texto ou palavra de uma string Criada com substring

            string cpf1 = cpfSemPonto.Substring(0,3);
            string cpf2 = cpfSemPonto.Substring(3,3);
            string cpf3 = cpfSemPonto.Substring(6, 3);
            string cpf4 = cpfSemPonto.Substring(9, 2);
            Console.WriteLine("\n CPF Sem ponto mas concatenado por SubString: " + cpf1 +
                                "." + cpf2 + "." + cpf3 + "-" + cpf4);

        }
        
    }
}
