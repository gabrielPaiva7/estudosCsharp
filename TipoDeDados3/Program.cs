Console.WriteLine("Atribuindo valores para bool e char");

Console.WriteLine();

bool ativo = true; //declarando variavel bool true
bool inativo = false; //declarando variavel bool false

Console.WriteLine(ativo);
Console.WriteLine(inativo);

Console.WriteLine(10 == 15); //COMPARADOR de IGUALDADE em C#, 10 igual a 15? deve retornar false
Console.WriteLine(10 == 10); //COMPARADOR de IGUALDADE em C#, 10 igual a 10? deve retornar true

int x = 10;
int y = 15;
Console.WriteLine(x > y); //COMPARADOR MAIOR QUE em C#, x maior que y? deve retornar false

char letra1 = 'A'; //caractere unicode é representado por char, somente um caractere entre aspas simples

string texto1 = "Essa é uma string";
texto1 = "Essa é uma string modificada"; //quando eu modifico uma string, a anterior ainda fica la no espaço da memória(é imutavel)
Console.WriteLine(texto1);



Console.ReadLine();