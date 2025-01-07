Console.WriteLine("## Operadores Lógicos ##\n");

bool c1 = 5 >= 7; //false, pois 5 não é maior ou igual a 7
bool c2 = 9 != 8; //true, pois 9 é diferente de 8
bool resultado;

Console.WriteLine($"c1 = {c1}");
Console.WriteLine($"c2 = {c2}\n");


//operador AND -> &&
resultado = c1 && c2; //false, se um resultado for false, sera false
Console.WriteLine($"Operador AND(&&) : {resultado}");

//operador OR -> ||
resultado = c1 || c2; //true, pois se c1 OU c2 for verdadeiro, sera verdadeiro
Console.WriteLine($"Operador OR(||) : {resultado}");

//operador NOT -> !
resultado = !c1;     //true, pois está invertendo c1, que é false
Console.WriteLine($"Operador NOT(!) : {resultado}");







Console.ReadKey();
