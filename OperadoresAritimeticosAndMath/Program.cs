Console.WriteLine("Hello, World! \n");

/*Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Seu nome é {nome} e sua idade é {idade} anos");*/


/*OPERADORES
 * adição ->    (+)
 * subtração ->    (-)
 * multiplicação ->  (*)
 * divisão -> (/)
 * módulo(retorna o resto da divisao) -> (%)
 
(---------------------------------------------------------------------------------------)


 * Constantes Matemáticas:

    Math.PI: Representa a constante pi (π), que é aproximadamente 3.14159.

    Math.E: Representa a constante e, a base dos logaritmos naturais, que é aproximadamente 2.71828.

Funções Trigonométricas:

    Math.Sin(double a): Calcula o seno do ângulo especificado (em radianos).

    Math.Cos(double a): Calcula o cosseno do ângulo especificado (em radianos).

    Math.Tan(double a): Calcula a tangente do ângulo especificado (em radianos).

Funções Exponenciais e Logarítmicas:

    Math.Exp(double a): Retorna e elevado à potência especificada.

    Math.Log(double a): Retorna o logaritmo natural (base e) do número especificado.

    Math.Log10(double a): Retorna o logaritmo na base 10 do número especificado.

    Math.Pow(double base, double exponent): Retorna um número elevado à potência de outro número.

Funções de Arredondamento:

    Math.Round(double a): Arredonda um valor para o inteiro mais próximo.

    Math.Ceiling(double a): Retorna o menor inteiro maior ou igual ao número especificado.

    Math.Floor(double a): Retorna o maior inteiro menor ou igual ao número especificado.

    Math.Truncate(double a): Retorna a parte inteira do número, descartando a fração.

Funções de Mínimo e Máximo:

    Math.Min(double a, double b): Retorna o menor dos dois valores especificados.

    Math.Max(double a, double b): Retorna o maior dos dois valores especificados.

Funções de Raiz e Potência:

    Math.Sqrt(double a): Calcula a raiz quadrada do número especificado.

    Math.Cbrt(double a): Calcula a raiz cúbica do número especificado.

Outras Funções Úteis:

    Math.Abs(double a): Retorna o valor absoluto do número especificado.

    Math.Sign(double a): Retorna um valor que indica o sinal de um número.

    Math.IEEERemainder(double x, double y): Calcula o resto da divisão de x por y de acordo com o padrão IEEE.*/



Console.WriteLine("Digite o valor de x:");
int x = Convert.ToInt32( Console.ReadLine()); //PRECISA CONVERTER POIS RETORNA STRING O READLINE

Console.WriteLine("Digite o valor de y:");
int y = Convert.ToInt32( Console.ReadLine()); //PRECISA CONVERTER POIS RETORNA STRING O READLINE


Console.WriteLine($"Raiz quadrada de x = {Math.Sqrt(x)}");             //usando o método Math para calcular a raiz quadrada de um numero
Console.WriteLine($"Potencia de x elevado a y = {Math.Pow(x,y)}");    //usando o método Math para calcular a potencia de x elevado a y
Console.WriteLine($"Exponencial de x = {Math.Exp(x)}\n \n");              //usando o método Math para calcular o exponencial de x 
















Console.WriteLine($"Soma de x+y = {x+y}\n");
Console.WriteLine($"Subtração de x-y = {x-y}\n");
Console.WriteLine($"Multiplicação de x*y = {x*y} \n");
double divisao =  (double) x/y;                             //transformei a conta de divisao em double para um calculo mais preciso
Console.WriteLine($"Divisão de x/y = {divisao} \n");
Console.WriteLine($"Módulo de x%y = {x%y} \n");







Console.ReadKey();
