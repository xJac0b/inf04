using System;

const int n = 50;
int[] tablica = new int[n + 1];
WypelnijTablice(tablica);
Console.WriteLine("Podaj szukana liczbe: ");

int szukana = int.Parse(Console.ReadLine());
int indeks = ZnajdzElement(tablica, szukana);

Console.Write("Zawartość tablicy: ");
for (int i = 0; i < tablica.Length-1; i++)
{
    Console.Write(tablica[i] + ",");
}
Console.WriteLine();

if (indeks == tablica.Length - 1)
{
    Console.WriteLine("Nie znaleziono szukanej liczby");
}
else
{
    Console.WriteLine($"Znaleziono szukana liczbe na pozycji {indeks}");
}

void WypelnijTablice(int[] tablica)
{
    for (int i = 0; i < tablica.Length; i++)
    {
        tablica[i] = new Random().Next(1, 101);
    }
}
//******************************************************
// nazwa funkcji: ZnajdzElement
// argumenty:   tablica (int []) - tablica liczb całkowitych, w której szukamy elementu
// szukana (int) - szukana liczba
//typ zwracany: int, indeks znalezionego elementu
// informacje: funkcja wykorzystuje algorytm wyszukiwania z wartownikiem
// autor: 012345
//*****************************************************
int ZnajdzElement(int[] tablica, int szukana)
{
    tablica[tablica.Length - 1] = szukana;
    for (int i = 0; i < tablica.Length; i++)
    {
        if (tablica[i] == szukana) return i;
    }
    return tablica.Length - 1;
}