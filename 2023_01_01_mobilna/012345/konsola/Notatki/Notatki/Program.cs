using System;

Notatka notatka1 = new Notatka("Notatka 1", "Tresc notatki 1");
notatka1.Wyswietl();
notatka1.WyswietlDaneDiagnostyczne();

Console.WriteLine();

Notatka notatka2 = new Notatka("Notatka 2", "Tresc notatki 2");
notatka2.Wyswietl();
notatka2.WyswietlDaneDiagnostyczne();

/*
************************************************
 klasa: Notatka
 opis:  Zawiera informacje o notatce
 pola:  licznik_notatek (static int) - przechowuje ilość notatek
        uid (int) - przechowuje unikalny identyfikator notatki
        tytul (string) - przechowuje tytuł notatki
        tresc (string) - przechowuje treść notatki
 autor: 012345
************************************************
*/
class Notatka
{
    private static int licznik_notatek = 0;
    private int uid;
    protected string tytul, tresc;

    public Notatka(string tytul, string tresc)
    {
        licznik_notatek++;
        this.uid = licznik_notatek;
        this.tytul = tytul;
        this.tresc = tresc;
    }

    public void Wyswietl()
    {
        Console.WriteLine("Tytul: {0}\nTresc: {1}", tytul, tresc);
    }

    public void WyswietlDaneDiagnostyczne()
    {
        Console.WriteLine("{0};{1};{2};{3}", licznik_notatek, uid, tytul, tresc);
    }
}