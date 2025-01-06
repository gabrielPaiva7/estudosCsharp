Console.WriteLine("## Constantes ##\n");

const int ANO = 12; //constantes  devem ser iniciadas e nao podem ser alteradas

const int MES = 30, SEMANA = 7, QUINZENA = 15; //se forem do mesmo tipo, podem ser feitas na mesma linha

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine(DIAS_POR_MES);




double raio, perimetro, area;
const double PI = Math.PI;

Console.WriteLine("Informe o raio do circulo");
raio = Convert.ToDouble(Console.ReadLine());

//Calcula a área do circulo
area = PI * raio * raio;
Console.WriteLine($"A area do circulo é de {area}");

//Calcula o perímetro do círculo
perimetro = (PI * 2) * raio;
Console.WriteLine($"o perimetro do circulo é de {perimetro}");








Console.ReadKey();