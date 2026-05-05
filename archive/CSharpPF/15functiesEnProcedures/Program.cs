Console.Write("Typ een zin: ");
string zin = Console.ReadLine(); int aantalSpaties = 0;
for (int teller = 0; teller < zin.Length; teller++)
    if (zin[teller] == ' ')
        aantalSpaties++;
Console.WriteLine(aantalSpaties);
//Console.WriteLine(teller);

double CmNaarInch(double cm)
{
    return cm / 2.54;
}

double InchNaarCm(double inch)
{
    return inch * 2.54;
}

void TekenLijn(int lengte, char teken = '-')
{
    for (int i = 0; i < lengte; i++)
    {
        Console.Write(teken);
    }
    Console.WriteLine();
}

Console.Write("Afstand in cm: ");
double cm = double.Parse(Console.ReadLine());
Console.WriteLine($" {cm} cm = {CmNaarInch(cm)} inches");

TekenLijn(20);
Console.Write("Afstand in inches: ");
double inches = double.Parse(Console.ReadLine());
Console.WriteLine($" {inches} inches = {InchNaarCm(inches)} cm");


void Verwissel(ref int getal1, ref int getal2)
{
    int tussen = getal1;
    getal1 = getal2;
    getal2 = tussen;
}

void VerwisselNaarAndereVariabelen(int getal1, int getal2,
out int verwisseld1, out int verwisseld2)
{
    verwisseld1 = getal2;
    verwisseld2 = getal1;
}

int eerste = 10, tweede = 20;
Verwissel(ref eerste, ref tweede);
Console.WriteLine(eerste);
Console.WriteLine(tweede);


VerwisselNaarAndereVariabelen(eerste, tweede,
out int resultaat1, out int resultaat2);
Console .WriteLine(resultaat1);
Console .WriteLine(resultaat2);

