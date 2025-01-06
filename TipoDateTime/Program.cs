Console.WriteLine("## Struct DateTime ##\n");

DateTime DataAtual = DateTime.Now; //assim eu consigo a data atual(Dia,Mes,Ano,Hora,Minutos,Segundos)
Console.WriteLine(DataAtual);

DateTime DataHoje = new DateTime(2025, 01, 05); //assim eu consigo uma data especifica, (Ano,Mes,Dia)
Console.WriteLine(DataHoje);

DateTime DataHoraHoje = new DateTime(2025, 01, 05, 07,02,45);//assim eu consigo uma data especifica (Ano,Mes,Dia,Hora,Minuto,Segundo)
Console.WriteLine(DataHoraHoje);

Console.WriteLine("--------------------------------------------------------------------------");

DateTime DataHoje1 = DateTime.Now;

//Extrair informações da data atual:
Console.WriteLine(DataHoje1.Year); //Estraindo o ano da data de hoje
Console.WriteLine(DataHoje1.Month); //Estraindo o mes da data de hoje
Console.WriteLine(DataHoje1.Day); //Estraindo o dia da data de hoje
Console.WriteLine(DataHoje1.Hour); //Estraindo a hora da data de hoje
Console.WriteLine(DataHoje1.Minute); //Estraindo os minutos da data de hoje
Console.WriteLine(DataHoje1.Second); //Estraindo os segundos da data de hoje
Console.WriteLine(DataHoje1.Millisecond); //Estraindo os milisegundos da data de hoje

//Adicionando valores:
Console.WriteLine(DataHoje1.AddDays(30)); //Adiciona dias
Console.WriteLine(DataHoje1.AddMonths(1)); //Adiciona mes
Console.WriteLine(DataHoje1.AddHours(2)); //Adiciona horas
Console.WriteLine(DataHoje1.AddYears(5)); //Adiciona anos

//obter o dia da semana e do ano:
Console.WriteLine(DataHoje1);
Console.WriteLine(DataHoje1.DayOfWeek); //obtem o dia da semana
Console.WriteLine(DataHoje1.DayOfYear); //obtem o dia do ano

//data e formato longo e curto
Console.WriteLine(DataHoje1.ToLongDateString()); //domingo, 5 de janeiro de 2025
Console.WriteLine(DataHoje1.ToShortDateString()); // 05/01/2025

Console.WriteLine(DataHoje1.ToLongTimeString()); //07:19:35   horas,minutos e segundos
Console.WriteLine(DataHoje1.ToShortTimeString()); //07:19     horas e minutos





Console.ReadKey();