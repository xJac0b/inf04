Console.WriteLine("Liczba zarejestrowanych osób to {0}", Osoba.liczba_instancji);

//Konstruktor bezparametrowy
Osoba osoba1 = new Osoba();

//Wczytanie danych z klawiatury
Console.WriteLine("Podaj id: ");
int pobraneId = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj imię: ");
string pobraneImie = Console.ReadLine();

//Konstruktor z parametrami
Osoba osoba2 = new Osoba(pobraneId, pobraneImie);

//Konstruktor kopiujący
Osoba osoba3 = new Osoba(osoba2);

//Wypisanie danych
osoba1.Wypisz("Jan");
osoba2.Wypisz("Jan");
osoba3.Wypisz("Jan");
Console.WriteLine("Liczba zarejestrowanych osób to {0}", Osoba.liczba_instancji);


class Osoba
{
    private int id;
    private string imie;
    public static int liczba_instancji = 0;

    public Osoba()
    {
        id = 0;
        imie = String.Empty;
        liczba_instancji++;
    }

    public Osoba(int id, string imie)
    {
        this.id = id;
        this.imie = imie;
        liczba_instancji++;
    }
 
    public Osoba(Osoba o)
    {
        this.id = o.id;
        this.imie = o.imie;
        liczba_instancji++;
    }

    public void Wypisz(string imie)
    {
        if (this.imie == String.Empty)
            Console.WriteLine("Brak danych");
        else
            Console.WriteLine("Cześć {0}, mam na imię {1}", imie, this.imie);
    }
}