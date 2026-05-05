string[] keys = ["Q", "S", "P", "A", "T", "V", "X", "B", "C", "R", "J", "Y", "E", "D", "U", "O", "H", "Z", "G", "I", "F", "L", "N", "W", "K", "M"];
string inputSentence = "C# is cool!";
inputSentence = inputSentence.ToUpper();
System.Text.StringBuilder sb = new System.Text.StringBuilder("");
foreach (char letter in inputSentence)
    if (char.IsLetter(letter))
    {
        int positie = (int)letter -65;
        sb.Append(keys[positie]);
    } else
    {
        sb.Append(letter);
    }
Console.WriteLine(sb);













int LeesCijfer(string subject)
{
    Console.WriteLine($"Geef een cijfer voor {subject} tussen 1 en 10:");
    bool valid = int.TryParse(Console.ReadLine(), out int punten);

    while (!valid || punten < 1 || punten > 10)
    {
        Console.WriteLine($"Geef een cijfer voor {subject} tussen 1 en 10:");
        valid = int.TryParse(Console.ReadLine(), out punten);
    }
    return punten;

}

bool geslaagd(int punten)
{
    return punten >= 5 && punten <= 10;
}

string resultaat(string [,] data)
{
    int totaal = 0;
    for (int i = 0; i < data.Length / 2; i++)
    {
        totaal += int.Parse(data[i, 1]) *10 ;
    }
    totaal = totaal/3;
    switch (totaal)
    {
        case >= 50 and < 68:
            return "voldoende";
        case >= 68 and < 77:
            return "onderscheiding";
        case >= 77 and < 85:
            return "grote onderscheiding";
        case >= 85:
            return "grootste onderscheiding";
        default:
            return "onvoldoende";

    }
}

string[,] marks = {{"Wiskunde",""},
    {"Boekhouden",""},
    {"Informatica",""}};


for (int i = 0; i < marks.Length / 2; i++)
{
    int cifer = LeesCijfer(marks[i, 0]);
    marks[i, 1] = cifer.ToString();
}

for (int i = 0; i < marks.Length / 2; i++)
{
    bool ok = geslaagd(int.Parse(marks[i, 1]));
    if (!ok)
    {
        Console.WriteLine($"Deze leerling is niet geslaagd voor {marks[i, 0]}.");
    }
}

Console.WriteLine(resultaat(marks));
