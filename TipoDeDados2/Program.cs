Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();

float n2 = 1.234f;  //declarando como float tem a precisao de 6 a 9 digitos depois da virgula, precisa do f depois do numero
double n1 = 1.234d; //declarando como double tem a precisao de 15 a 17 digitos depois da virgula, nao precisa do d depois do numero, se um numero nao tiver nada, ele sera double

decimal n3; //declarando como decimal tem a precisao de 28 a 9 digitos depois da virgula, precisa do m depois do numero
n3 = 1.234m; //assim eu to declarando variaveis em 2 etapas, primeiro o declaro ela, e aqui o valor.

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);

Console.ReadLine();

Console.WriteLine("Comparando a precisao de doubole, float e decimal");

float x = 1 / 3f; //a precisao é de 0,33333334
double y = 1 / 3d;//a precisao é de 0,3333333333333333
decimal z = 1 / 3m;//a precisao é d 0,3333333333333333333333333333

Console.WriteLine(y);
Console.WriteLine(x);
Console.WriteLine(z);

Console.ReadLine();