// TIPOS DE DADOS NO C#

// NUMÉRICOS

sbyte _sbyte = 0;       // min: -128 e max: 127
short _short = 0;       // min: -32768 e max: 32767
int _int = 0;           // min: -2^31 e max: 2^31 - 1
long _long = 0L;        // min: -2^63 e max: 2^63 - 1
byte _byte = 0;         // min: 0 e max: 256

ushort _ushort = 0;     // min: 0 e max: 65535
uint _uint = 0;         // min: 0 e max:  2^32 - 1
ulong _ulong = 0;       // min: 0 e max: 2^64 -1

float _float = 0F;      // min: ± 1,5 * 10^-45 e max: ± 3,4 * 10^38
double _double = 0;     // min: ± 5 * 10^-234 e max: ± 1,7 * 10^308
decimal _decimal = 0;   // min: 1 * 10^-28 e max: ± 7,9 * 10^28

// BOOLEANOS

bool _bool = false;     // false ou true (verdadeiro ou falso)

// CARACTERE

char _char = 'z';       // qualquer caractere unicode ("caracteres soltos", ex: 'a', '1', '$', etc...) 

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine); 

Console.WriteLine($"sbyte: {_sbyte}");
Console.WriteLine($"short: {_short}");
Console.WriteLine($"int: {_int}");
Console.WriteLine($"long: {_long}");
Console.WriteLine($"byte: {_byte}");

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine); // cria uma nova linha e acrescenta uma divisória abaixo

Console.WriteLine($"ushort: {_ushort}");
Console.WriteLine($"uint: {_uint}");
Console.WriteLine($"ulong: {_ulong}");

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine);

Console.WriteLine($"float: {_float}");
Console.WriteLine($"double: {_double}");
Console.WriteLine($"decimal: {_decimal}");

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine);

Console.WriteLine($"bool: {_bool}");

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine);

Console.WriteLine($"char: {_char}");

Console.WriteLine(Environment.NewLine + "--------------------------------" + Environment.NewLine); 