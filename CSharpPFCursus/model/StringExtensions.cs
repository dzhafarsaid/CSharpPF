using System;

namespace CSharpPFCursus.model;

public static class StringExtensions
{
    extension(string s)
    {
        //instance extension members
        public string ToUpperFirst()
        {
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        public string Right(int aantal)
        {
            if (s.Length <= aantal)
                return s;
            return s.Substring(s.Length - aantal);
        }

        public int WordCount
        {
            get => s.Split([' ', '.', '?']).Length;
        }

        //static extension method
        public static string GenereerCode(int lengte)
        {
            string toegelatenTekens = 
                "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var code = new char[lengte];
            var random = new Random();
            for (int i = 0; i < lengte; i++)
            {
                code[i] = toegelatenTekens[random.Next(toegelatenTekens.Length)];
            }
            return new string(code);
        }
    }
}
