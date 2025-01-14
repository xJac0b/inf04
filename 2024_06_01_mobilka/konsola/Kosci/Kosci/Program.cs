using System;

int ileKostek = 0;
do
{
    Console.WriteLine("Ile kostek chcesz rzucić(3-10)");
    ileKostek = int.Parse(Console.ReadLine());
} while (ileKostek < 3 || ileKostek > 10);

while (true)
{
    int[] wynikLosowania = Losuj(ileKostek);

    int sumaPunktow = LiczPunkty(wynikLosowania);
    Console.WriteLine($"Liczba uzyskanych punktów: {sumaPunktow}");
    Console.WriteLine("Jeszcze raz? (t/n)");
    char znak = Console.ReadLine()[0];
    if (znak == 'n')
        break;
}

/*
************************************************
 nazwa: Losuj
 opis: Zwraca tablicę losowych liczb z zakresu 1-6 o długości podanej w parametrze
 parametry: ileKostek - liczba kostek do wylosowania
 zwracany typ i opis: int[] - tablica z wynikami losowania
 autor: 012345
************************************************
*/
int[] Losuj(int ileKostek)
{
    int[] wynik = new int[ileKostek];
    Random rand = new Random();

    for (int i = 0; i < ileKostek; i++)
    {
        wynik[i] = rand.Next(1, 7);
        Console.WriteLine($"Kostka {i + 1}: {wynik[i]}");
    }
    return wynik;
}

int LiczPunkty(int[] oczka)
{
    int suma = 0;
    int[] licznikOczek = new int[7];
    for (int i = 0; i < oczka.Length; i++)
    {
        licznikOczek[oczka[i]]++;
    }

    for(int i = 0; i<oczka.Length; i++)
    {
        if (licznikOczek[oczka[i]] > 1)
        {
            suma += oczka[i];
        }
    }
    return suma;
}
