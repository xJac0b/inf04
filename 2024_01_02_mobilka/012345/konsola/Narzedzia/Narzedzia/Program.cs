using System;

Console.WriteLine("Wpisz łańcuch znaków: ");
string tekst = Console.ReadLine();
Console.WriteLine("Liczba samogłosek w tekście: " + Narzedzia.ZliczSamogloski(tekst));
Console.WriteLine("Tekst po usunięciu sąsiednich powtórzeń: " + Narzedzia.UsunSasiedniePowtorzenia(tekst));

/*
************************************************
 klasa: Narzedzia
 opis: Klasa zawiera statyczne metody narzędziowe do obsługi łańcuchów znaków.
 metody: ZliczSamogłoski - przyjmuje łańcuch znaków i zwraca liczbę samogłosek w tekście
          UsunSasiedniePowtorzenia - przyjmuje łańcuch znaków i zwraca tekst po usunięciu sąsiednich powtórzeń
 autor: 012345
************************************************
**/
class Narzedzia
{
    public static int ZliczSamogloski(string tekst)
    {
        string samogloskiString = "aąeęiouóyAĄEĘIOUÓY";
        int liczbaSamoglosek = 0;
        foreach(char c in tekst)
        {
            if (samogloskiString.Contains(c))
            {
                liczbaSamoglosek++;
            }
        }
        return liczbaSamoglosek;
    }

    public static string UsunSasiedniePowtorzenia(string tekst)
    {
        string wyjsciowyTekst = "";
        for(int i = 0; i<tekst.Length; i++)
        {
            if (wyjsciowyTekst.Length > 0 && wyjsciowyTekst[wyjsciowyTekst.Length - 1] == tekst[i]) 
                continue;     
            wyjsciowyTekst += tekst[i];
        }
        return wyjsciowyTekst;
    }

}