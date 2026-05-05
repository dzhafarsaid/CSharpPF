string woord = "leppel";
bool palindrom = true;

for (int vanafBegin = 0, vanafEinde = woord.Length -1; vanafBegin <vanafEinde;
        vanafBegin++,vanafEinde--)
    if (woord[vanafBegin] != woord[vanafEinde])
    {
        palindrom = false;
    }
    Console.WriteLine(palindrom);