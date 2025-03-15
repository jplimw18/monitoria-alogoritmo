int numero = 0;

Console.Write("Insira um número inteiro: ");
numero = int.Parse(Console.ReadLine());

Console.WriteLine($"O antecessor de {numero} é {numero - 1}");
Console.WriteLine($"O sucessor de {numero} é {numero + 1}");
