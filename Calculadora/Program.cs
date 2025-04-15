using Calculadora;


Operacoes operacao = new Operacoes();

bool whi = true;

List<string> listaOperacoes = new List<string>() { "SUM", "SUB", "MUL", "DIV"};

while (whi)
{
    try
    {
        Console.Clear();
        Console.WriteLine(operacao.Menu());
        var opcao = Console.ReadLine();

        if (listaOperacoes.Contains(opcao.ToUpper()))
        {
            Console.WriteLine("\nDigite o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            var retorno = operacao.OpcaoSelecionada(opcao, numero1, numero2);
            Console.WriteLine(retorno);
        }
        else
        {
            Console.WriteLine("Opção inválida");
            whi = false;
        }

        if (Convert.ToInt32(opcao) == 0)
        {
            Console.WriteLine($"\nObrigado por usar a calculadora !");
            whi = false;
        }
    }
    catch (Exception ex)
    {
        var retorno = ex.Message;
        Console.WriteLine($"Ocorreu um erro: {retorno}");
    }
}