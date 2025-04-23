using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public void LoopingCalcular()
        {
            bool whi = true;

            List<string> listaOperacoes = new List<string>() { "SUM", "SUB", "MUL", "DIV" };

            while (whi)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine(Menu());
                    var opcao = Console.ReadLine();

                    if (opcao == "0")
                    {
                        Console.WriteLine($"\nObrigado por usar a calculadora !");
                        whi = false;
                    }
                    else if (listaOperacoes.Contains(opcao.ToUpper()))
                    {
                        Console.WriteLine("\nDigite o primeiro número: ");
                        int numero1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nDigite o segundo número: ");
                        int numero2 = Convert.ToInt32(Console.ReadLine());

                        var retorno = OpcaoSelecionada(opcao, numero1, numero2);
                        Console.WriteLine(retorno);

                        Console.WriteLine("Pressione o enter para continuar !");
                        var enter = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                        whi = false;
                    }
                }
                catch (Exception ex)
                {
                    var retorno = ex.Message;
                    Console.WriteLine($"Ocorreu um erro: {retorno}");
                    Console.WriteLine("Pressione o enter para continuar !");
                    var enter = Console.ReadLine();
                }
            }
        }

        private string Menu()
        {
            var menu = 
                "\nBem-vindo a sua Calculadora em C#" +
                "\n=================================" +
                "\n" +
                "\nEscolha a operação que deseja realizar ou 0 para sair:" +
                "\n - Soma = SUM" +
                "\n - Subtração = SUB" +
                "\n - Multiplicação = MUL" +
                "\n - Divisão = DIV" +
                "\n=================================";

            return menu;
        }

        private string OpcaoSelecionada(string op, int a, int b)
        {
            string opcao = "";

            switch (op)
            {
                case "SUM":
                    opcao = $"\nO Resultado da operação {op} é: {a+b}";
                    break;
                case "SUB":
                    opcao = $"\nO Resultado da operação {op} é: {a-b}";
                    break;
                case "MUL":
                    opcao = $"\nO Resultado da operação {op} é: {a*b}";
                    break;
                case "DIV":
                    opcao = a==0 || b ==0 ? 
                        throw new DivideByZeroException("Não é possível dividir um número por zero !") 
                        : 
                        $"\nO Resultado da operação {op} é: {a/b}";
                    break;
                default:
                    opcao = "\nOpção inválida, por favor verifique a opção selecionada";
                    break;
            }

            return opcao;
        }
    }
}
