using System.Reflection.Metadata;
using System;

string peselString = Console.ReadLine();
int[] pesel = new int[11];
for (int i = 0; i<peselString.Length; i++)
{
    pesel[i] = peselString[i]-'0';
}

char plec = SprawdzPlec(pesel);
if (plec == 'K')
{
    Console.WriteLine("Kobieta");
}
else
    Console.WriteLine("Mężczyzna");

bool zgodnoscSumyKontrolnej = SprawdzPesel(pesel);
if (zgodnoscSumyKontrolnej)
    Console.WriteLine("Suma kontrolna zgodna z podanym numerem PESEL");
else
    Console.WriteLine("Suma kontrolna niezgodna z podanym numerem PESEL");


char SprawdzPlec(int[] pesel)
{
    if (pesel[9] % 2 == 0)
        return 'K';
    return 'M';
}

/*
**********************************************
nazwa funkcji: SprawdzPesel
opis funkcji: Funkcja sprawdza zgodność sumy kontrolnej (ostatnia cyfra) z resztą numeru PESEL
parametry: pesel (int []) - przechowuje numer PESEL
zwracany typ i opis: bool - zwraca true gdy suma kontrolna jest zgodna z resztą numeru PESEL
autor: 012345
***********************************************
*/
bool SprawdzPesel(int[] pesel)
{
    int[] wagi = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3];
    int suma = 0;
    int suma_kontrolna = 0;
    for(int i = 0; i < wagi.Length; i++)
        suma += (pesel[i] * wagi[i]);
    int modulo = suma % 10;
    if (modulo != 0)
        suma_kontrolna = 10 - modulo;
    Console.WriteLine(suma_kontrolna);
    return pesel[10] == suma_kontrolna;
}