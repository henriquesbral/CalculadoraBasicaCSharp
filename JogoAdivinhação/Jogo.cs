using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdivinhação
{
    public class Jogo
    {
        private int Numero() 
        { 
            Random random = new Random(); 
            int num = random.Next(1, 11);
            return num;
        }
        
        public string Menu()
        {
            return ($"\nBem vindo ao jogo adivinhação do número !" +
                     "\nRegras do jogo:" +
                     "\n Você possui três tentativas;" +
                     "\n Os números são somente inteiros;" +
                     "\n O número está entre 1 e 10;" +
                     "\n" +
                     "\nDigite o número abaixo: " +
                     "\n").ToString();
        }

        public void JogoFinal()
        {
            int tentativas = 3;
            string retorno = "";

            while (tentativas >= 0)
            {
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero == Numero())
                {
                    retorno = $"Voçê acertou !";
                    Console.WriteLine(retorno);
                    break;
                }
                else
                {
                    retorno = tentativas == 0 ? "Voçê expirou suas tentativas, jogo encerrado!" : $"Voçê possuí mais {tentativas} tentativa.";
                    Console.WriteLine(retorno);
                }
                tentativas --;
            }
        }
    }
}
