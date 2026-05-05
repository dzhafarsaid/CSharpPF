int aankoopbedrag = int.Parse("200");
double koorting;
switch (aankoopbedrag)
{
    case < 25:
        koorting = 0.01;
        break;
    case >= 25 and < 50:
        koorting = 0.02;
        break;
    case >= 50 and <= 100:
        koorting = 0.03;
        break;
    case > 100:
        koorting = 0.05;
        break;
}
Console.WriteLine(aankoopbedrag * koorting);


int year = int.Parse("2006");
bool isLeapYear;
if (year % 400 == 0)
{
    isLeapYear = true;
}
else if (year % 100 == 0)
{
    isLeapYear = false;
}
else if (year % 4 == 0)
{
    isLeapYear = true;
}
else
{
    isLeapYear = false;
}

if (isLeapYear)
{
    Console.WriteLine($"{year} is a leap year.");
}
else
{
    Console.WriteLine($"{year} is NOT a leap year.");
}


DateTime vandaag = DateTime.Parse("27,04,2026");
int dayOfTheWeek = (int)vandaag.DayOfWeek;
string openingsuren = string.Empty;
string boodschap = string.Empty;
switch (dayOfTheWeek)
{
    case >= 1 and <= 5:
        openingsuren = "9u00 tot 12-00 en van 13u00 tot 18u00 ";
        boodschap = "We wensen u een prettige werkdag!";
        break;
    case  6:
        openingsuren = "10u00 tot 12-00";
        boodschap = "We wensen u een fijn weekend!";
        break;
    case 0:
        openingsuren = "Gesloten";
        boodschap = "We wensen u een fijn weekend!";
        break;
}
Console.WriteLine(openingsuren);
Console.WriteLine(boodschap);