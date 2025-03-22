string mensagemUsuario = "";

Console.Write("Digite uma mensagem: ");
mensagemUsuario = Console.ReadLine();

Console.Write("Gostaria de editar sua mensagem? (s/n): ");
char editar = Convert.ToChar(Console.ReadLine());
// O Convert tem a mesma função que o Parse, porém, caso a variável seja nula,
// o Convert garante que ela teá o valor base do seu tipo e não travará o programa!

if (editar == 's')
{
    int numeroFuncao = 0;

    Console.WriteLine("1 - Adicionar ao ínicio; ");
    Console.WriteLine("2 - Adicionar ao fim; ");
    Console.WriteLine("3 - Trocar palavra. ");

    do
    {
        Console.Write(Environment.NewLine + "Digite o número da operação que deseja realizar: ");
        numeroFuncao = Convert.ToInt32(Console.ReadLine());
    } while (numeroFuncao <= 0 || numeroFuncao > 3);

    switch (numeroFuncao){
        case 1:
            Console.WriteLine(Environment.NewLine + " Adicionar ao ínicio ".PadLeft(30, '>'));

            Console.Write(Environment.NewLine + "Insira o conteudo a ser adicionado: ");
            string txtAdicional = Console.ReadLine();

            mensagemUsuario = $"{txtAdicional} {mensagemUsuario}";

            Console.WriteLine($"{Environment.NewLine}Mensagem editada: '{mensagemUsuario}'");
            break;

        case 2:
            Console.WriteLine(Environment.NewLine + " Adicionar ao Fim ".PadLeft(30, '>'));

            Console.Write(Environment.NewLine + "Insira o conteudo a ser adicionado: ");
            txtAdicional = Console.ReadLine();

            mensagemUsuario = $"{mensagemUsuario} {txtAdicional}";

            Console.WriteLine($"{Environment.NewLine}Mensagem editada: '{mensagemUsuario}'");
            break;

        case 3:
            Console.WriteLine(Environment.NewLine + " Adicionar ao Fim ".PadLeft(30, '>'));

            Console.WriteLine($"Mensagem oiginal: '{mensagemUsuario}'");
            Console.Write($"{Environment.NewLine}-> Insira o texto a ser substituído: ");
            string txtParaTrocar = Console.ReadLine();

            Console.Write($"{Environment.NewLine}-> Insira o texto a ser colocado: ");
            string txtNovo = Console.ReadLine();

            mensagemUsuario = mensagemUsuario.Replace(txtParaTrocar, txtNovo);
            Console.Write($"{Environment.NewLine}Mensagem editada: '{mensagemUsuario}'");
            
            break;
    }
}

Console.WriteLine(Environment.NewLine + "Pressione qualquer tecla para finalizar o programa...");
Console.ReadKey();

