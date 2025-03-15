double valorDolar = 0.0, cotacao = 0.0, valorReal = 0.0;

Console.Write("Insira um valor em dólar: ");
valorDolar = double.Parse(Console.ReadLine());

Console.Write("Insira a cotação atual: ");
cotacao = double.Parse(Console.ReadLine());

valorReal = valorDolar * cotacao;

Console.WriteLine($"Você tem: BRL {valorReal.ToString("F2")}"); // ToString("F2") formata o valor para ter apenas 2 casas decimais