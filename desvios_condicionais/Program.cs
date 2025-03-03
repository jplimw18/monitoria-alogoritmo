// DESVIOS CONDICIONAIS

// If e Else
// O 'If' espera uma condição para ser validada
// Se ela for verdadeira: executa o bloco do if;
// Se for falsa: não executa o bloco do if e, SE EXISTIR UM BLOCO Else, executa os comandos dentro do else

// Ex 1 - Clássico, com if e else juntos
// condiçõa: 3 é menor que 1?

if (3 < 1) 
{
    Console.WriteLine("Condição é verdadeira");
}
else
{
    Console.WriteLine("Condição é falsa");
}

// Ex 2 - somente o if
// condição: 10 é igual a 1?

if (10 == 1) 
{
    Console.WriteLine("Condição verdadeira");
}

// Ex 3 - aplicando validações praticas

string senha = "123";

Console.Write("Por favor, insira a senha: ");
string senhaDigitada = Console.ReadLine();

if (senha == senhaDigitada)
{
    Console.WriteLine("Acesso liberado");
}
else
{
    Console.WriteLine("Acesso negado");
}

Console.WriteLine("Pressione qualquer tecla para continuar...");
Console.ReadKey();


// Encadeamento de if's
// o Encadeamento nos permite fazer verificações seguidas de forma otimizada

// Ex 1 - Retornando o dia da semana

Console.WriteLine("Insira um valor de 1 a 7");
int dia = int.Parse(Console.ReadLine());

if (dia == 1)
{
    Console.WriteLine("Domingo");
}
else if (dia == 2)
{
    Console.WriteLine("Segunda-feira");
}
else if (dia == 3)
{
    Console.WriteLine("Terça-feira");
}
else if (dia == 4)
{
    Console.WriteLine("Quarta-feira");
}
else if (dia == 5)
{
    Console.WriteLine("Quinta-feira");
}
else if (dia == 6)
{
    Console.WriteLine("Sexta-feira");
}
else if (dia == 7)
{
    Console.WriteLine("Sábado");
}

Console.WriteLine("Pressione qualquer tecla para continuar");
Console.ReadKey();

// Switch Case
// mesmo príncipio do Encademento

// Ex - Retornando o mês correspondente
Console.Write("Insira um número de 1 a 12");
int mes = int.Parse(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("Janeiro");
        break;

    case 2:
        Console.WriteLine("Janeiro");
        break;

    case 3:
        Console.WriteLine("Janeiro");
        break;

    case 4:
        Console.WriteLine("Janeiro");
        break;

    case 5:
        Console.WriteLine("Janeiro");
        break;

    case 6:
        Console.WriteLine("Janeiro");
        break;

    case 7:
        Console.WriteLine("Janeiro");
        break;

    case 8:
        Console.WriteLine("Janeiro");
        break;

    case 9:
        Console.WriteLine("Janeiro");
        break;

    case 10:
        Console.WriteLine("Janeiro");
        break;

    case 11:
        Console.WriteLine("Janeiro");
        break;

    case 12:
        Console.WriteLine("Janeiro");
        break;

    default:
        Console.WriteLine("se você está vendo isso é porquê nenhum dos casos foi correspondido");
        break;
}

Console.WriteLine("fim");
Console.ReadKey();


