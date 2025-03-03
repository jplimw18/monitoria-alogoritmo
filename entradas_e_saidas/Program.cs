// -------------------- COMANDOS DE SAÍDA/OUTPUT NO CONSOLE --------------------

Console.WriteLine("------------------- OUTPUTS/SAÍDA -------------------" + Environment.NewLine);

// NÃO QUEBRA A LINHA
Console.Write("Esta mensagem foi escrita usando Console.Write()"); 

// QUEBRA A LINHA NO FINAL DA MENSAGEM 
Console.WriteLine("Esta mensagem foi escrita usando Console.WriteLine()"); 



// CARACTERES CHAVE PARA MANIPULAÇÃO DE EXIBIÇÃO

// QUEBRA DE LINHA
Console.Write("Quebrando a linha\nsem WriteLine\n");

// INSERE UM CARACTERE INVISÍVEL E QUEBRA A LINHA (CAUSA EFEITO DE UMA NOVA LINHA)
Console.WriteLine("\r\n \r\nCriando uma nova linha com espaçamento"); 


// -------------------- COMANDOS DE ENTRADA --------------------
Console.WriteLine("------------------- INPUTS/ENTRADA -------------------" + Environment.NewLine);

Console.Write("Insira seu nome: ");

// LÊ VALOR INSERIDO PELO USUÁRIO E ATRIBUI A VARIÁVEL
string name = Console.ReadLine(); 

// PODEMOS EXIBIR OS VALORES ARMAZENADOS COM OS COMANDOS DE SAÍDA
Console.WriteLine("Bem Vindo(a), " + name); 

Console.Write("Insira sua idade: ");

// O COMANDO 'Console.ReadLine()' ESPERA QUE O USUÁRIO DIGITE TEXTOS NO GERAL (strings)
// POR ISSO É NECESSÁRIO CONVERTER O VALOR DE ENTRADA PARA CONSEGUIR ARMAZENAR VALORES NUMÉRICOS ENTRE OUTROS
int age = int.Parse(Console.ReadLine());

Console.Write("Insira sua altura: ");
double height = double.Parse(Console.ReadLine());

// PODEMOS EXIBIR VALORES USANDO INTERPOLAÇÃO
// COLOQUE  '$' ANTES DE ABRIR ASPAS ("") E, ONDE QUISER EXIBIR O VALOR, ABRA CHAVES '{}' E INSIRA O NOME DA VARIÁVEL/VALOR DENTRO
Console.WriteLine($"{name} tem {age} anos e {height}m de altura");

// -------------------- ADICIONAIS -------------------- 

// EMITE UM SOM DE BEEP
Console.Beep();

// MUDA COR DE FUNDO DO CONSOLE
Console.BackgroundColor = ConsoleColor.Cyan;
Console.ForegroundColor = ConsoleColor.Gray;

// AGUARDA UMA TECLA SER PRESSIONADA PARA AVANÇAR
Console.ReadKey();

Console.WriteLine("fim");





