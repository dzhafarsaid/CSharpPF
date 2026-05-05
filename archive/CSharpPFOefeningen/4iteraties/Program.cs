const string ALFABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
string bankNumber = "063-1547563-60";
bankNumber = bankNumber.Replace("-","");
bankNumber += "BE00";
Console.WriteLine(bankNumber);
System.Text.StringBuilder controlNumber = new System.Text.StringBuilder();
char letter;
for (int i = 0; i< bankNumber.Length; i++)
{
    letter = bankNumber[i];
    if (char.IsLetter(letter))
    {
        controlNumber.Append(ALFABET.IndexOf(letter) + 10);
    }
    else
    {
        controlNumber.Append(letter);
    }
}
ulong devision = ulong.Parse(controlNumber.ToString()) % 97;
string controlGetal = (98-devision).ToString();
string ibanNumber = "BE" +
    (controlGetal.Length == 2 ? controlGetal : "0" + controlGetal) +
    bankNumber.Substring(0, bankNumber.Length - 4);

// Add spaces every 4 characters
ibanNumber = ibanNumber.Insert(12, " ");
ibanNumber = ibanNumber.Insert(8, " ");
ibanNumber = ibanNumber.Insert(4, " ");

Console.WriteLine($"Rekeningnummer: {bankNumber.Substring(0, bankNumber.Length - 4)}");
Console.WriteLine($"Als IBAN: {ibanNumber}");