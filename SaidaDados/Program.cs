Console.WriteLine("Saída de dados : Formatação \n");

string nome = "Maria";
int idade = 18;

Console.WriteLine($"{nome} tem {idade} anos"); //interpolação (MELHOR JEITO)

Console.WriteLine(nome+ " tem "+idade+" anos"); //concatenação

Console.WriteLine("----------------------------------------------------------------------");

/*Formatação usando seuencias Escapes, tudo isso dentro de uma string (" ")
 * 
 \a = sinal sonoro (alerta)
\b = backspace (5)
\f = alimentação de formulario
\n = nova linha
\r = carriage return
\t = tabulação horizontal
\v = tabulação vertical
\' = aspas simples
\" = aspas duplas
\\ = barra invertida
\? = interrogação
\u ooo = caractere ASCII na notação unicode
\x hh = Caractere ASCII na notação hexadecimal
*/

string local = "c:\dados\poesias.txt"; //jeito errado
local = "c:\\dados\\poesias.txt"; //jeito certo

string frase = "Ele falou "Não fui eu" "; //jeito errado
frase = "Ele falou \"Não fui eu\" "; //jeito certo            //no console: "ele falou "Não fui eu" "
Console.WriteLine(frase);








Console.ReadLine();
