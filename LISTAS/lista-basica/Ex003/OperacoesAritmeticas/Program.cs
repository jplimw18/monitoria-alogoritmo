double valorA = 0.0, valorB = 0.0;

Console.Write("Insira um valor: ");
valorA = double.Parse(Console.ReadLine());

Console.Write("Insira outro valor: ");
valorB = double.Parse(Console.ReadLine());


Console.Write($"Resultado soma: {valorA + valorB}");
Console.Write($"Resultado subtração: {valorA - valorB}");

if (valorB == 0)
{
    Console.Write("Resultado divisão: indeterminado (±∞)");
}
else
{
    Console.Write($"Resultado divisão: {valorA / valorB}");
}

Console.Write($"Resultado multiplicação: {valorA * valorB}");
