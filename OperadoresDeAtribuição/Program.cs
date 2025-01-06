Console.WriteLine("Hello, World!");

// Operador de Atribuição (=)
// Significado: Atribui um valor a uma variável.
var x = 5;
// Exemplo: A variável 'x' recebe o valor '5'.

// Operador de Atribuição de Adição (+=)
// Significado: Adiciona o valor da direita ao valor da esquerda e atribui o resultado à variável da esquerda.
x += 3;
// Exemplo: Equivalente a 'x = x + 3'. Se 'x' era '5', agora 'x' é '8'.

// Operador de Atribuição de Subtração (-=)
// Significado: Subtrai o valor da direita do valor da esquerda e atribui o resultado à variável da esquerda.
x -= 2;
// Exemplo: Equivalente a 'x = x - 2'. Se 'x' era '8', agora 'x' é '6'.

// Operador de Atribuição de Multiplicação (*=)
// Significado: Multiplica o valor da direita pelo valor da esquerda e atribui o resultado à variável da esquerda.
x *= 4;
// Exemplo: Equivalente a 'x = x * 4'. Se 'x' era '6', agora 'x' é '24'.

// Operador de Atribuição de Divisão (/=)
// Significado: Divide o valor da esquerda pelo valor da direita e atribui o resultado à variável da esquerda.
x /= 3;
// Exemplo: Equivalente a 'x = x / 3'. Se 'x' era '24', agora 'x' é '8'.

// Operador de Atribuição de Módulo (%=)
// Significado: Calcula o módulo (resto da divisão) do valor da esquerda pelo valor da direita e atribui o resultado à variável da esquerda.
x %= 5;
// Exemplo: Equivalente a 'x = x % 5'. Se 'x' era '8', agora 'x' é '3'.


Console.WriteLine($"Valor inicial de x = {x}");

Console.WriteLine($"x+=3 ==> {x += 3}" );
Console.WriteLine($"x-=2 ==> {x -= 2}" );
Console.WriteLine($"x*=4 ==> {x *= 4}" );
Console.WriteLine($"x/=3 ==> {x /= 3}" );
Console.WriteLine($"x%=5 ==> {x %= 5}" );

Console.ReadKey();