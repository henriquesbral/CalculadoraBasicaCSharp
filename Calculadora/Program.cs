using Calculadora;


Operacoes operacao = new Operacoes();

bool whi = true;

while (whi)
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