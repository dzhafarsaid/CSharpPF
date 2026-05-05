string naam;
naam = "Asterix";
string groteKrijger;
groteKrijger = naam;
Console.WriteLine(groteKrijger);

string krijger1 = "Asterix";
string krijger2 = "Obelix";
string samen1 = krijger1 + " en " + krijger2;
Console.WriteLine(samen1);

int seizoenen = 4;
string eindeZin = " seizoenen";
string samen = seizoenen + eindeZin;
Console.WriteLine(samen);

System.Text.StringBuilder bericht = 
    new System.Text.StringBuilder("hallo");
Console.WriteLine(bericht); //toont hallo
bericht.Append(" iedereen");
Console.WriteLine(bericht); 

string groterKrijger = "Asterix";
string kleinerKrijger = "asterix";
Console.WriteLine(krijger1 == krijger2);
Console.WriteLine(krijger1 == groteKrijger);
Console.WriteLine(krijger1 == kleinerKrijger);
Console.WriteLine(krijger1.CompareTo(krijger2));
Console.WriteLine(kleinerKrijger.Length);


string naam1 = " Asterix en Obelix";
Console.WriteLine(naam.ToUpper());
Console.WriteLine(naam.ToLower());
Console.WriteLine(naam);
char eersteLetter = naam[0];
Console.WriteLine(eersteLetter);
char laasteLetter = naam[naam.Length - 1];
Console.WriteLine(laasteLetter);
Console.WriteLine(naam[^2]);

string kinderenWoord = "7";
byte kinderen = Convert.ToByte(kinderenWoord);
Console.WriteLine(kinderen);

const float CMInch = 2.54f;
Console.WriteLine("Geef een lengte in cm: ");
float lengteIncm = float.Parse("7");
Console.WriteLine("lengte in inch: " + lengteIncm /CMInch);


Console.WriteLine("Dit is een dubbel aanhalingsteken: \".");
Console.WriteLine("De standaard windows directory is c:\\windows");
char aanhalingsteken = '\'';
Console.WriteLine(aanhalingsteken);
Console .WriteLine( @"De standaard windows directory is c:\windows" );
Console .WriteLine( @"Dit is een dubbel aanhalingsteken: ""." );

Console.WriteLine("    ");
string tekst = null;
Console.WriteLine( string .IsNullOrWhiteSpace(tekst));
tekst = string .Empty;
Console.WriteLine( string .IsNullOrWhiteSpace(tekst));
tekst = "\t \n" ;
Console.WriteLine( string .IsNullOrWhiteSpace(tekst));
tekst = "hallo" ;
Console.WriteLine( string .IsNullOrWhiteSpace(tekst));

Console.WriteLine(krijger1 + " en " + krijger2 + " zijn goede vrienden." );
Console.WriteLine("{0} en {1} zijn goede vrienden",krijger1,krijger2);
Console.WriteLine("    ");

float puntenWiskunde = 7.0f;
float puntenInformatica = 8.0f;
float puntenEngels = 5.0f;
float gemiddelde = (puntenWiskunde + puntenInformatica + puntenEngels) /3;
Console.WriteLine("gemiddelde: {0}",gemiddelde);
Console.WriteLine("gemiddelde: {0:F2}",gemiddelde);
Console.WriteLine("    ");

double straal = 5.0;
Console.WriteLine($"de omtrek van een cirkel met straal {straal} cm" +
                  $" bedraagt {2* Math.PI * straal} cm.");

Console.WriteLine($"de omtrek van een cirkel met straal {straal} cm" +
                  $" bedraagt {2* Math.PI * straal:0.00} cm.");

Console.WriteLine("    ");

var jsonString = """
    {
    "voornaam":"Jan",
    "naam":"Jansen"
    }
    """;
Console.WriteLine(jsonString);

var jsonString2 = @"
    {
    ""voornaam"":""Jan"",
    ""naam"":""Jansen""
    }";
Console.WriteLine(jsonString2);

Console.WriteLine("    ");

string welkom = """"
Welkom """Jan"""
"""" ;
Console.WriteLine(welkom); //Welkom """Jan"""

Console.WriteLine("    ");

string naam3 = "Jan";
int leeftijd = 30;
string tekst2 = $"""
    hallo {naam3},
    Je bent {leeftijd} jaar oud.
""";
Console.WriteLine(tekst2);

Console.WriteLine("    ");

var json = $$"""
    {
    "naam": "{{naam}}"},
    "leeftijd":{{leeftijd}}
}
""";
Console.WriteLine(json);