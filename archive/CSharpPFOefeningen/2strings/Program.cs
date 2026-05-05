Console.WriteLine("Wat is uw vooraam:");
string voornaam = Console.ReadLine();
Console.WriteLine("Wat is uw familienaam:");
string familienaam = Console.ReadLine();
Console.WriteLine("Wat is uw telefoon Nummer:");
string telefoonNummer = Console.ReadLine();
Console.WriteLine("Wat is uw Post Code:");
string postCode = Console.ReadLine();

char eersteLetter = char.ToUpper(familienaam[0]);
char tweedeLetter = char.ToLower(voornaam[0]);
char deerdeNummer = telefoonNummer[1];
int vierdeNummer = (int.Parse(postCode[^1].ToString())) ;
string wachtwoord = $"{tweedeLetter}{eersteLetter}{deerdeNummer}*{vierdeNummer*vierdeNummer}";
Console.WriteLine(wachtwoord);


