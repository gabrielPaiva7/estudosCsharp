Console.WriteLine("## Entrada de dados ##\n");

/* ReadLine() = lê uma única linha de entrada do fluxo de entrada padrão. Retorna (string), usar pra pedir pra digitar algo no console
 
Read() = lê apenas um único caractere do fluxo de entrada padrão

ReadKey() = lê apenas um único caractere do fluxo de entrada padrão.
            Obtém a proxima tecla pressionada pelo usuário
            Retorna um tipo ConsoleKeyInfo
            É usado pra segurar a tela até que o usuário pressione uma tecla*/


Console.WriteLine("Informe seu nome:");
string nome = Console.ReadLine(); //so pode ser usado como string, podendo converter depois

Console.WriteLine("Informe sua idade:");
int idade = Convert.ToInt32(Console.ReadLine()); //pedindo pra digitar a idade e converter para int

Console.WriteLine($"\nO seu nome é {nome} e sua idade é de {idade} anos");

Console.ReadKey();