using System.ComponentModel.Design.Serialization;

int anoNascimento = 0, anoAtual = 0, idade = 0;

Console.Write("Insira o ano que você nasceu: ");
anoNascimento = int.Parse(Console.ReadLine());

Console.Write("Insira o ano atual: ");
anoAtual = int.Parse(Console.ReadLine());

idade = anoAtual - anoNascimento;

Console.WriteLine($"Você tem {idade} anos!");