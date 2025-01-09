bool[] A = new bool[101];
WypelnijSito(A);
List<int> liczbyPierwsze = ZnajdzLiczbyPierwsze(A);
Console.Write("Liczby pierwsze: ");
for(int i = 0; i<liczbyPierwsze.Count; i++)
{
    Console.Write(liczbyPierwsze[i]);
    if(i != liczbyPierwsze.Count - 1)
        Console.Write(", ");
}

/*
*******************************************************
 nazwa funkcji: WypelnijSito
 parametry wejściowe: tablica (bool []) - tablica wypełniana wartościami
 wartość zwracana: brak (void)
 informacje: funkcja pozostawia sito z wartościami true dla liczby pierwszych
 autor: 012345
****************************************************
*/
void WypelnijSito(bool[] tablica)
{
    for(int i = 2; i< tablica.Length; i++)
        tablica[i] = true;

    for (int i = 2; i * i < tablica.Length; i++)
    {
        if (tablica[i] == true)
        {
            for (int j = 2 * i; j < tablica.Length; j += i)
            {
                tablica[j] = false;
            }
        }
    }
}
List<int> ZnajdzLiczbyPierwsze(bool[] tablica)
{
    List<int> liczbyPierwsze = [];
    for (int i = 2; i < tablica.Length; i++)
    {
        if (tablica[i])
            liczbyPierwsze.Add(i);
    }
    return liczbyPierwsze;
}