Console.WriteLine("## Nullable Types ##\n"); //o \n faz pular a proxima linha

int? i = null; 
double? d = null;  //colocando o ? apos definir o tipo da variavel, ela vira um nullable type, podendo ser null, ou seja, nao ter nenhum valor
bool? b = null;    //um nullable type é diferente, nao posso atribuir um valor de nullable a um nao nullable

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(b);



int? num = null;
if (num.HasValue) //HasValue: true se tiver um valor, false se nao tiver (null)
{
    Console.WriteLine($"num = {num.Value}"); //Value: exibe o valor atribuido
}
else
{ Console.WriteLine("num nao possui um valor (null)"); }


Console.ReadKey();

//o NullableType pode ser usado uando o null(sem valor algum) for válido no contexto  estamos tratando.