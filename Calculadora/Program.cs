using Calculadora;


Operacoes operacao = new Operacoes();

bool whi = true;

while (whi)
{
    try
    {
        Console.Clear();
        Console.WriteLine(operacao.Menu());
        var opcao = Console.ReadLine();

        if (Convert.ToInt32(opcao) == 0)
        {
            Console.WriteLine($"Obrigado por usar a calculadora !");
            whi = false;
        }
    }
    catch (Exception ex)
    {
        var retorno = ex.Message;
        Console.WriteLine($"Ocorreu um erro: {retorno}");
    }
}