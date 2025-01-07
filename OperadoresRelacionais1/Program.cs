Console.WriteLine("Operadores Relacionais");


// O resultado de uma operação relacional terá como resultado true ou false


int x = 10; 
int y = 20;

Console.WriteLine(x==y); //false, pois x não é igual a y
Console.WriteLine(x<y);   //true, pois x é menor que y
Console.WriteLine(x<=y);   //true, pois x é menor ou igual a y
Console.WriteLine(x>y);   //false, pois x não é maior que y
Console.WriteLine(x>=y);   //false, pois x não é maior ou igual a y
Console.WriteLine(x!=y);   //true, pois x é diferente de y 

Console.WriteLine("-----------------------------------------------------------");

string a = "curso";
string b = "Curso";

Console.WriteLine(a==b); //false, pois um é maiusculo e outro nao

Console.WriteLine(a.Equals(b)); //false, método que determina se duas string tem o mesmo valor ou não

Console.ReadKey();