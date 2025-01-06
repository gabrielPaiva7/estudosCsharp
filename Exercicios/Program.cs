Console.WriteLine("EXERCICIOS");

/*Exercícios fase 1
1- Crie uma variável chamada idade e atribua a ela o valor 35 e exiba o seu valor.
2- Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
3- Crie uma variável chamada altura e atribua a ela o valor 3.45.
4- Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba o seu valor.*/

int idade  = 35; //1
Console.WriteLine(idade);

string nome = "Maria"; //2
Console.WriteLine(nome);

double altura = 3.45d; //3
Console.WriteLine(altura);

DateTime data = new DateTime(1999,09,04); //4
Console.WriteLine(data.ToShortDateString());

const int ANO = 12; //5
Console.WriteLine(ANO);

double? nota = 7.80; //6
Console.WriteLine(nota);

/* Tipos Comuns:                             //7

    Valor: int, float, double, decimal, char, struct, enum.

    Armazenados na pilha (stack).
    Copiados diretamente, cada variável tem sua própria cópia dos dados.
    Geralmente mais rápidos devido ao armazenamento na pilha.
    
    ----------------------------------------------------------------------------------

    Referencia: string, array, class, object.

    Armazenados no heap, com referências na pilha.
    Copiada a referência, várias variáveis podem apontar para o mesmo objeto.
    Podem ter overhead de memória devido ao gerenciamento no heap.


Tipos por valor – Armazenam os dados diretamente onde cada variável tem a cópia dos dados e são
armazenados na memória Stack
Tipos por referência – Não armazenam os dados diretamente e cada variável contém uma referência
ao local da memória onde os dados estão. São armazenados na memória Heap
*/

Console.WriteLine("------------------------------------------------------------------------------");

/*Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
(int) x = 10;
(double) numero = 7.99;
(char ) letra = 'C';
(float ) temperatura = 27.4f;
(bool ) ativo = false;
(string ) nome = "Manoel";
(decimal ) salario = 950.99m;
(DateTime) hoje = DateTime.Now; */

Console.WriteLine("-------------------------------------------------------------------------------------");

/*Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por
referência (R) :
(V) int n = 1;
(R) string titulo = "A vida";
(V) float f = 12.45f;
(V) double d = 5.45;
(V) decimal valor = 10.99m;
(V) char sexo = ‘M’;
(R) object o = null;*/

Console.WriteLine("---------------------------------------------------------------------------------------");

/*Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a
seguir imprima o valor da soma de x com y. (Use o operador aritmético + para realizar a
operação de soma)*/

int x = 77;
int y = 66;
Console.WriteLine($"A soma dos números é de {x+y}");

Console.WriteLine("-----------------------------------------------------------------------------------------");

/*Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e
string?

bool: false

char: \0 (caractere NUL, Unicode U+0000)

int: 0

double: 0.0

float: 0.0f

decimal: 0.0m

string: null */

Console.WriteLine("-------------------------------------------------------------------------");

/*Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
considerando a nomenclatura usada:
(F ) double 1valor = 12.45;
(F ) string #nome = "Pedro";
(V ) float _temperatura = 12.45f;
(F ) double int = 5;
(F ) decimal renda extra = 91.45m;
(F ) bool status$conta = false;
( V) string titulo3 = “Tópico 1”;
(V ) float salario_mensal = 1999.55f;
(V ) int percentualValorDesconto = 5;
( V) const bool MENSALIDADE_EM_DIA = true;*/

Console.WriteLine("-----------------------------------------------------------------------------")

/* O que é um nullable type e qual a sua utilidade ?
 
 É um tipo de valor que pode receber um valor null
São usados para representar um valor indefinido/ausente para um um tipo de valor ou para tratar com
valores null em cenários onde podemos ter ou não valores atribuídos como informações de um banco
de dados

 O que é Camel Case ? Dê um exemplo de sua aplicação.

 Convenção de nomenclatura para nomes compostos onde a primeira letra da primeira palavra é iniciada
com minúscula e a letra de cada palavra seguinte que compõe o nome deve ser iniciada com maiúscula
Ex: taxaDeDesconto , impostoRendaPessoaFisica, descontoSobreValorTotal


 O que é Pascal Case ? Dê um exemplo de sua aplicação.


Convenção de nomenclatura para nomes compostos onde a primeira letra de cada palavra que
compõe o nome deve ser iniciada com maiúscula
Ex: NomeCompletoAssinante , ValorImpostoSobreServico , TotalDesconto*/