﻿Console.WriteLine("## Operadores Incremento e Decremento ## \n");


//var x = 10;
//x++;  //incrementa 1 a variavel, mesma coisa que x = x+1
//Console.WriteLine(x); //o resultado será 11


//Console.WriteLine();


//var y = 10;
//y--;   //decrementa 1 da variavel, mesma coisa que y = y-1
//Console.WriteLine(y); //o resultado será 9


int x = 0;
Console.WriteLine($"x = {x}");

//pós-incremento ==> primeiro resolve depois incrementa
int resultado1 = x++ + 10;
Console.WriteLine($"pós-incremento ==> {resultado1}");
Console.WriteLine($"valor de x ==> {x}\n");

//pré-incremento ==> primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;
Console.WriteLine($"pré-incremento ==> {resultado2}");
Console.WriteLine($"valor de y ==> {y}");

Console.ReadKey();

int x1 = 0;
Console.WriteLine($"x = {x1}");

//pós-decremento -> primeiro resolve depois decrementa
int resultado3 = x1-- + 10;

Console.WriteLine($"pós-decremento ==> {resultado3}");
Console.WriteLine($"valor de x1 ==> {x1}\n");

//pré-decremento -> primeiro decrementa depois resolve
int y1 = 0;
Console.WriteLine($"y1 = {y1}");
int resultado4 = --y1 + 10;

Console.WriteLine($"pré-decremento ==> {resultado4}");
Console.WriteLine($"valor de y1 ==> {y1}\n");

Console.ReadKey();



















Console.ReadKey();