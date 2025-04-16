using ConversorMoedas;

ConverterMoeda converter = new ConverterMoeda();

List<int> opcoes = new List<int>() {1,2,3,4};
bool whi = true;
while (whi)
{
    Console.Clear();
    converter.Menu();
    Console.WriteLine("\nSelecione a moeda que deseja converter ou 0 para sair: ");
    var moedaSelecionada = Convert.ToInt32(Console.ReadLine());

    if (moedaSelecionada == 0)
    {
        Console.WriteLine("Obrigado por utilizar o nosso conversor de moedas !");
        whi = false;
    }
    else if (!opcoes.Contains(moedaSelecionada))
    {
        throw new Exception("Opção inválida por gentileza verifique novamente !");
    }
    else
    {
        Console.WriteLine($"Insira o valor abaixo para conversão: ");
        var valorAConverter = Convert.ToDouble(Console.ReadLine());

        var retorno = converter.OpcaoSelecionada(moedaSelecionada, valorAConverter);
        Console.WriteLine(retorno);
        Console.WriteLine("\nPressione enter para continuar !");
        var enter = Console.ReadLine();
    }
}