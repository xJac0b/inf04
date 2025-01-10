int[] tablica = new int[100];
for(int i = 0; i < tablica.Length; i++)
{
    tablica[i] = new Random().Next(0, 1001);
}
Console.WriteLine("Tablica przed posortowaniem: ");
foreach(int i in tablica)
{
    Console.Write(i + ", ");
}
Sortuj(tablica);
Console.WriteLine();
Console.WriteLine("Tablica po posortowaniu: ");
foreach (int i in tablica)
{
    Console.Write(i + ", ");
}

void Sortuj(int[] tablica)
{
    bool zamiana = true;
    while(zamiana)
    {
        zamiana = false;
        for(int i = 0; i< tablica.Length-1; i++)
        {
            if (tablica[i] > tablica[i+1])
            {
                int temp = tablica[i];
                tablica[i] = tablica[i + 1];
                tablica[i + 1] = temp;
                zamiana = true;
            }
        }
    }
}
