using System;

namespace SobreCarga
{
    /*Sobrecarga são diferentes possibilidades de entrada de dados para os metodos. Ex. Abaixo: */
    class Pessoa
    {
        public int Andar()
        {
            return 1;
        }

        public int Andar(int level)
        {
            return Andar() * level;
        }

        public int Correr()
        {
            return Andar() * 2;
        }
         
        public int Pedalar()
        {
            return Andar() * 4; 
        }
    }
}
