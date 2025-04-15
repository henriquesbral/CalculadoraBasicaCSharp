using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public string Menu()
        {
            var menu = 
                "Bem-vindo a sua Calculadora em C#" +
                "\n=================================" +
                "\n" +
                "\nEscolha a operação que deseja realizar ou 0 para sair:" +
                "\n- Soma = SUM" +
                "\n- Subtração = SUB" +
                "\n- Multiplicação = MUL" +
                "\n- Divisão = DIV";

            return menu;
        }

        public string OpcaoSelecionada(string op, int a, int b)
        {
            string opcao = "";

            switch (op)
            {
                case "SUM":
                    var retornoSum = Soma(a, b);
                    opcao = $"\nO Resultado da operação {op} é: {retornoSum}";
                    break;
                case "SUB":
                    var retornoSub = Subtrair(a, b);
                    opcao = $"\nO Resultado da operação {op} é: {retornoSub}";
                    break;
                case "MUL":
                    var retornoMul = Multiplicar(a, b);
                    opcao = $"\nO Resultado da operação {op} é: {retornoMul}";
                    break;
                case "DIV":
                    var retornoDiv = Dividir(a, b);
                    opcao = $"\nO Resultado da operação {op} é: {retornoDiv}";
                    break;
                default:
                    opcao = "\nOpção inválida, por favor verifique a opção selecionada";
                    break;
            }

            return opcao;
        }

        private int Soma(int a, int b)
        {
            return a + b;
        }
        private int Subtrair(int a, int b)
        {
            return a - b;
        }
        private int Multiplicar(int a, int b)
        {
            return a * b;
        }
        private int Dividir(int a, int b)
        {
            return a / b;
        }
    }
}
