using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class ConverterMoeda
    {
        private double Dolar = 5.8859;
        private double Euro = 6.6656;
        private double BitCoinDolar = 83441.83;
        private double BitCoinReais = 491124.38;

        public void Menu()
        {
            string menu = $"Bem vindo ao conversor de moedas para reais!" +
                           "\n As moedas disponíveis para conversão são:" +
                           "\n1 - Dólar" +
                           "\n2 - Euro" +
                           "\n3 - BitCoin em Dólar" +
                           "\n4 - BitCoin em Reais" +
                           "\nValores das moedas atualizados hoje ás 21:30" +
                           "\n";
            Console.WriteLine(menu);            
        }

        public string OpcaoSelecionada(int op, double valor)
        {
            var opcao = op;
            string retorno = "";
            switch (opcao)
            {
                case 1:
                    retorno = $"O valor de R$ {valor} convertido em Dólar é: R$ {RetornaValorConvertido(valor, Dolar)}";
                    break;
                case 2:
                    retorno = $"O valor de R$ {valor} convertido em Euro é: R$ {RetornaValorConvertido(valor, Euro)}";
                    break;
                case 3:
                    retorno = $"O valor de R$ {valor} convertido em BitCoin em dólar é: R$ {RetornaValorConvertido(valor, BitCoinDolar)}";    
                    break;
                case 4:
                    retorno = $"O valor de R$ {valor} convertido em BitCoin em reais é: R$ {RetornaValorConvertido(valor, BitCoinReais)}";
                    break;
                default:
                    retorno = "Opção inválida, por gentileza verifique novamente as opções";
                    break;
            }

            return retorno;
        }

        public decimal RetornaValorConvertido(double valor, double moeda)
        {
            decimal valorConvertido = 0;

            valorConvertido = Convert.ToDecimal(valor * moeda);

            return valorConvertido;
        }
    }
}
