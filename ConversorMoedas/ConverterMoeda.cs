using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class ConverterMoeda
    {
        private double Dolar = 5.73;
        private double Euro = 6.6656;
        private double BitCoinDolar = 83441.83;
        private double BitCoinReais = 491124.38;

        public void LoopingConversao()
        {
            List<int> opcoes = new List<int>() { 1, 2, 3, 4 };
            bool whi = true;
            while (whi)
            {
                Console.Clear();
                Menu();
                Console.WriteLine("\nSelecione a moeda que deseja converter ou 0 para sair: ");
                var moedaSelecionada = Convert.ToInt32(Console.ReadLine());

                if (moedaSelecionada == 0)
                {
                    Console.WriteLine("Obrigado por utilizar o nosso conversor de moedas !");
                    whi = false;
                }
                else if (!opcoes.Contains(moedaSelecionada))
                {
                    Console.WriteLine("Opção inválida por gentileza verifique novamente !");
                    Console.WriteLine("\nPressione enter para continuar !");
                    var enter = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Insira o valor abaixo para conversão: ");
                    var valorAConverter = Convert.ToDouble(Console.ReadLine());

                    var retorno = OpcaoSelecionada(moedaSelecionada, valorAConverter);
                    Console.WriteLine(retorno);
                    Console.WriteLine("\nPressione enter para continuar !");
                    var enter = Console.ReadLine();
                }
            }
        }

        private void Menu()
        {
            string menu = $"\n Bem vindo ao conversor de moedas para reais!" +
                           "\n As moedas disponíveis para conversão são:" +
                           "\n 1 - Dólar = R$ 5,72" +
                           "\n 2 - Euro = R$ 6,52" +
                           "\n 3 - BitCoin em Dólar = US$ 93017,58" +
                           "\n 4 - BitCoin em Reais = R$ 532.617,69" +
                           "\n Valores das moedas atualizadas 22/04/2025 ás 21:30" +
                           "\n";
            Console.WriteLine(menu);            
        }

        private string OpcaoSelecionada(int op, double valor)
        {
            var opcao = op;
            string retorno = "";
            switch (opcao)
            {
                case 1:
                    retorno = $"O valor de R$ {valor.ToString("N2")} convertido em Dólar é: US$ {RetornaValorConvertido(valor, Dolar).ToString("N2")}";
                    break;
                case 2:
                    retorno = $"O valor de R$ {valor.ToString("N2")} convertido em Euro é: € {RetornaValorConvertido(valor, Euro).ToString("N2")}";
                    break;
                case 3:
                    retorno = $"O valor de R$ {valor.ToString("N2")} convertido em BitCoin em dólar é: US$ {RetornaValorConvertido(valor, BitCoinDolar).ToString("N2")}";    
                    break;
                case 4:
                    retorno = $"O valor de R$ {valor} convertido em BitCoin em reais é: R$ {RetornaValorConvertido(valor, BitCoinReais).ToString("N2")}";
                    break;
                default:
                    retorno = "Opção inválida, por gentileza verifique novamente as opções";
                    break;
            }

            return retorno;
        }

        private decimal RetornaValorConvertido(double valor, double moeda)
        {
            decimal valorConvertido = 0;

            valorConvertido = Convert.ToDecimal(valor / moeda);

            return valorConvertido;
        }
    }
}
