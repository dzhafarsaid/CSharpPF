string[] namen = [ "Asterix", "Obelix", "Idefix"];
Console.WriteLine("Beginsituatie:");
foreach (string naam in namen)
    Console.WriteLine(naam);
Array.Sort(namen);
Console.WriteLine("Na Sort:");
foreach (string naam in namen)
    Console.WriteLine(naam);
Array.Reverse(namen);
    Console.WriteLine("Na Reverse:");
foreach (string naam in namen)
    Console.WriteLine(naam);
string[] kopie = new string[namen.Length];
Array.Copy(namen,kopie,namen.Length);
foreach (string naam in namen)
    Console.WriteLine(naam);
Console.WriteLine("Eerste Idefix op positie: " +
    Array.IndexOf(namen, "Idefix"));