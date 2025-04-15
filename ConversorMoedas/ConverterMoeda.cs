using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorMoedas
{
    public class ConverterMoeda
    {
        private double Dolar = 5.8605;
        private double Euro = 6.6225;
        private double BitCoinDolar = 85906.10;
        private double BitCoinReais = 504074.64;

        public void Menu()
        {
            string menu = $"Bem vindo ao conversor de moedas para reais!" +
                           "\n As moedas disponíveis para conversão são:" +
                           "\n - Dólar" +
                           "\n - Euro" +
                           "\n - BitCoin em Dólar" +
                           "\n - BitCoin em Reais" +
                           "\n" +
                           "\nSelecione a moeda que deseja converter: ";
            Console.WriteLine(menu);
            
        }

        public double RetornaValorConvertido(double n)
        {
            double valor = 0;

            return valor;
        }
    }
}
