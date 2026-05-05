const int GemLichTempCelsius = 37;
double GemLichTempFarenheit = Math.Round(GemLichTempCelsius * (9 / 5.0) + 32, 2);
Console.Write("The avarage tempreture is ");
Console.WriteLine(GemLichTempFarenheit);


int seconds = 3736;
int u = seconds / 3600;
int remaining = seconds % 3600;
int m = remaining / 60;
int s = remaining % 60;
Console.WriteLine($"U:{u} M:{m} S:{s}");


Console.WriteLine("Vooer Uw snoep prijs:");
double prijs = double.Parse("0,23");
Console.WriteLine($"Uw prijs is {prijs}");
Console.WriteLine($"Uw wisselgeld is {2.0 - prijs}");
int prijsInCents = (int)(prijs*100);
int wisselgeld = 200 - prijsInCents;
int euro1 = wisselgeld / 100;
wisselgeld -= euro1 * 100;
int cent50 = wisselgeld / 50;
wisselgeld -= cent50 * 50;
int cent20 = wisselgeld / 20;
wisselgeld -= cent20 * 20;
int cent10 = wisselgeld / 10;
wisselgeld -= cent10 * 10;
int cent5 = wisselgeld / 5;
wisselgeld -= cent5 * 5;
int cent2 = wisselgeld / 2;
wisselgeld -= cent2 * 2;
int cent1 = wisselgeld / 1;
wisselgeld -= cent1 * 1;
if (euro1 >= 1 ) {Console.WriteLine($"1 euro : {euro1}");};
if (cent50 >= 1 ) {Console.WriteLine($"50 cents : {cent50}");};
if (cent20 >= 1 ) {Console.WriteLine($"20 cents : {cent20}");};
if (cent10 >= 1 ) {Console.WriteLine($"10 cents : {cent10}");};
if (cent5 >= 1 ) {Console.WriteLine($"5 cents : {cent5}");};
if (cent2 >= 1 ) {Console.WriteLine($"2 cents : {cent2}");};
if (cent1 >= 1 ) {Console.WriteLine($"1 cents : {cent1}");};