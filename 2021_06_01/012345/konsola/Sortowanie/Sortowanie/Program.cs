Sortowanie sortowanie = new Sortowanie();
sortowanie.WczytajLiczby();
sortowanie.Sortuj();
sortowanie.WypiszLiczby();

public class Sortowanie
{
    private int[] liczby = new int[10];

    public void WczytajLiczby()
    {
        Console.WriteLine("Prosze wpisac pojedynczo 10 liczb");
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Prosze wpisac liczbe nr " + i.ToString() + ": ");
                string wejscie = Console.ReadLine();
                liczby[i] = int.Parse(wejscie);
            }
            Console.WriteLine("Pomyślnie wczytano liczby");
        }
        catch (Exception _) {
            Console.WriteLine("Wystąpił błąd, uruchom program ponownie");
        }
    }

    public void WypiszLiczby()
    {
        Console.WriteLine("Posortowane liczby: ");
        for(int i = 0; i<10; i++)
        {
            Console.Write(liczby[i] + " ");
        }
    }


    /********************************************************
    * nazwa funkcji: ZnajdzMaksimum
    * parametry wejściowe: od - początek zakresu przeszukiania tablicy
    * wartość zwracana: int - indeks najwyzszej wartosci na danym przedziale
    * autor: 012345    
    * ****************************************************/
    private int ZnajdzMaksimum(int od)
    {
        int maksimumWartosc = liczby[od], maksimumIndeks = od;
        for(int i = od; i<liczby.Length; i++)
        {
            if (liczby[i] > maksimumWartosc)
            {
                maksimumWartosc = liczby[i];
                maksimumIndeks = i;
            }
        }
        return maksimumIndeks;
    }

    /********************************************************
    * nazwa funkcji: Sortuj
    * parametry wejściowe: brak - funkcja działa na polu klasy
    * wartość zwracana: brak - funkcja sortuje tablice 
    *                   przechowywaną jako pole klasy
    * autor: 012345    
    * ****************************************************/
    public void Sortuj()
    {
        for(int i = 0; i<liczby.Length-1; i++)
        {
            int maksimumIndeks = ZnajdzMaksimum(i);
            int zmiennaPomocnicza = liczby[i];
            liczby[i] = liczby[maksimumIndeks];
            liczby[maksimumIndeks] = zmiennaPomocnicza;
        }
    }
}