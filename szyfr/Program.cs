using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alfabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            Console.WriteLine("Podaj slowo do zaszyfrowania.");
            string slowo = Console.ReadLine();
            char[] zaszyfrowaneslowo = slowo.ToCharArray();
            char[] odszyfrowaneslowo = new char[zaszyfrowaneslowo.Length];

            int i;
            for (i = 0; i < zaszyfrowaneslowo.Length; i++)
            {
                char c = zaszyfrowaneslowo[i];
                int index = Array.IndexOf(alfabet, c);
                int letterPosition = (index += 3) % 26;
                char zaszyfrowanalitera = alfabet[letterPosition];
                zaszyfrowaneslowo[i] = zaszyfrowanalitera;

            }
            string napisaneslowo = String.Join("", zaszyfrowaneslowo);
            Console.WriteLine(napisaneslowo);


            Console.WriteLine("Podaj slowo do odszyfrowania.");
            string slowo1 = Console.ReadLine();
            
            int o;
            for (i = 0; i < odszyfrowaneslowo.Length; i++)
            {
                char c = zaszyfrowaneslowo[i];
                int index = Array.IndexOf(alfabet, c);
                int letterPosition = (index -= 3) % 26;
                char zaszyfrowanalitera = alfabet[letterPosition];
                odszyfrowaneslowo[i] = zaszyfrowanalitera;

            }
            string napisaneslowo1 = String.Join("", odszyfrowaneslowo);
            Console.Write(napisaneslowo1);
           }

    }
}



