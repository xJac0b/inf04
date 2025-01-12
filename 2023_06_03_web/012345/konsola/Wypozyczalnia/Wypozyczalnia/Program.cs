using System;

Film film = new Film();
Console.WriteLine("Tytuł: {0}, Liczba wypożyczeń: {1}", film.ZwrocTytul(), film.ZwrocLiczbeWypozyczen());
film.UstawTytul("Matrix");
Console.WriteLine("Metoda set dla tytułu");
Console.WriteLine("Tytuł: {0}, Liczba wypożyczeń: {1}", film.ZwrocTytul(), film.ZwrocLiczbeWypozyczen());
film.Wypozycz();
Console.WriteLine("Metoda wypożycz inkrementująca liczbę wypożyczeń");
Console.WriteLine("Tytuł: {0}, Liczba wypożyczeń: {1}", film.ZwrocTytul(), film.ZwrocLiczbeWypozyczen());

/*
******************************************************
nazwa klasy: Film
pola:  tytul - (string) przechowuje tytul stringu
       liczba_wypozyczen - (int) przechowuje liczbe wypozyczen
metody: Wypozycz, void – inkrementuje liczbę wypożyczeń
informacje: Klasa reprezentuje film
autor: 012345
*****************************************************
*/
class Film
{
    protected string tytul = String.Empty;
    protected int liczba_wypozyczen = 0;

    public void UstawTytul(string tytul)
    {
        this.tytul = tytul;
    }

    public string ZwrocTytul()
    {
        return tytul;
    }

    public int ZwrocLiczbeWypozyczen()
    {
        return liczba_wypozyczen;
    }

    public void Wypozycz()
    {
        liczba_wypozyczen++;
    }
}