// ------------------- ESTRUTURAS DE REPETIÇÃO -------------------

// WHILE
// SÓ INICIA E SE MANTÉM ENQUANTO UMA CONDIÇÃO É VERDADEIRA 
// (pode ser que a ação dentro do loop nunca seja executada por não atender a condição esperada)

// Ex - Adivinhe o número
int numSecreto = 2;
uint numTentativas = 1;

Console.WriteLine("Que número estou pensando? (0 a 10): ");
int numDigitado = int.Parse(Console.ReadLine());

while (numDigitado != numSecreto) {
    Console.WriteLine("Passou longe");
    numTentativas++; // ACRESCENTA UMA TENTATIVA A CADA ERRO; (n++ => n = n + 1)
}

Console.WriteLine($"Você adivinhou com {numTentativas} tentaiva(s)");

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

//  DO WHILE
// INICIA PELO MENOS UMA VEZ, INDEPENDENTEMENTE DA CONDIÇÃO SER VERDADEIRA OU FALSA
// SÓ SE REPETE SE A CONDIÇÃO FOR VERDADEIRA

// Ex - Programa somador com opção de realizar uma nova operação

Console.WriteLine("Bem vindo(a) ao somador: ");
string resp = "n";

do
{
    Console.Write("Digite um número: ");
    double num1 = double.Parse(Console.ReadLine());

    Console.Write("Digite outro número: ");
    double num2 = double.Parse(Console.ReadLine());

    double resultado = num1 + num2;
    Console.WriteLine($"{num1} + {num2} = {resultado}");
    // Console.WriteLine($"{num1} + {num2} = {num1 + num2}"); // Opcção em que não é necessário a variável resultado

    Console.WriteLine("Deseja rodar o programa novamente? (s/n)");
    resp = Console.ReadLine();

} while (resp == "s");

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();

// FOR
// USADO PARA REALIZAR UMA AÇÃO NUM DETERMINADO NÚMERO DE VEZES

// Ex 1 - Contagem Progressiva

Console.WriteLine("Contagem progressiva: " + Environment.NewLine);
for (int i = 1; i <= 10; ++i) {
    Console.WriteLine($"Contagem progressiva em: {i}");
}

// Ex 2 - Contagem Regressiva
Console.WriteLine("Contagem regressiva: " + Environment.NewLine);
for (int i = 10; i >= 0; --i) {
    Console.WriteLine($"Contagem regressiva em: {i}");
}

// Ex 3 - Somador

Console.WriteLine("Bem vindo(a) ao somador");
Console.WriteLine("Insira a quantidade de números que deseja somar: ");
int quantidadeNumeros = int.Parse(Console.ReadLine());
double soma = 0;

for (int i = 0; i < quantidadeNumeros; i++)
{
    Console.Write($"Insira o {i + 1}º número: ");
    double num = double.Parse(Console.ReadLine());
    soma = soma + num;
}

Console.WriteLine($"A soma é: {soma}");

Console.WriteLine("Pressione qualquer tecla para sair do programa");
Console.ReadKey();
