Console.WriteLine("## Conversão de tipos ## \n");

int varInt = 100;                //int usa 4 bytes
double varDouble = varInt;       //double usa 8 bytes, então é possivel converter automaticamente

//byte -> 1 byte
//short -> 2 bytes
//int -> 4 bytes
//float -> 4 bytes
//long -> 8 bytes
//double -> 8 bytes
//decimal -> 16bytes

Console.WriteLine(varDouble);

Console.WriteLine("------------------------------------------------------------------");

double varDouble1 = 12.456;          //8bytes
int varInt1 = (int)varDouble1;       //4 bytes, forçando a conversão(vai perder precisao pois int n suporta numeros decimais

Console.WriteLine(varInt1);

Console.WriteLine("--------------------------------------------");

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;            // 10 / 4 = 2.5, porem se eu nao converter o resultado ele mostrar um int(2)
Console.WriteLine(resultado);

Console.WriteLine("--------------CONVERSAO STRING----------------------------");

int valorInt = 10;
double valorDouble = 5.35;
bool valorBool = true;

Console.WriteLine(Convert.ToString(valorInt)); //converti o int pra string
Console.WriteLine(Convert.ToDouble(valorInt)); //converti int para double
Console.WriteLine(Convert.ToString(valorBool)); //converti bool para string
Console.WriteLine(Convert.ToInt32(valorDouble));// converti double para int (vai exibir apenas 5)




int varInt3 = 10000;
Console.WriteLine(Convert.ToByte(varInt3)); //vai ocorrer um erro na execução pois o valor é mt grande para o byte





Console.ReadLine();
