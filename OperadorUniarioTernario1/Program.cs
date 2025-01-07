Console.WriteLine("## Operador Uniário e Ternário ##\n");

Console.WriteLine("Informe o número:\n");
var numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O negativo de {numero} é {-numero}"); //-numero retorna o negativo de numero, +numero retornaria o propio numero


Console.WriteLine("----------------------------Ternário--------------------------");

Console.WriteLine("Informe a temperatura:\n");
var temp = Convert.ToDouble(Console.ReadLine());

var resultado = temp > 27 ? "Quente" : "Frio"; //(?:) SE(?) temp maior que 27, "Quente", CASO CONTRÁRIO(:) "Frio" 
Console.WriteLine(resultado);


//pode se fazer mais condicionais, mas ficará confuso e é melhor o uso de if


Console.ReadKey();  
