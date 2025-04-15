
using ConversorMoedas;

ConverterMoeda converter = new ConverterMoeda();

bool whi = true;
while (whi)
{
    converter.Menu();
    converter.RetornaValorConvertido();
}