using System;

Console.WriteLine("Podaj 1. liczbę:");
int a = int.Parse(Console.ReadLine());
if (a <= 0)
{
    Console.WriteLine("Liczba musi być całkowita dodatnia");
    return;
}
Console.WriteLine("Podaj 2 liczbę:");
int b = int.Parse(Console.ReadLine());
if (b <= 0)
{
    Console.WriteLine("Liczba musi być całkowita dodatnia");
    return;
}

int nwd = Nwd(a, b);
Console.WriteLine("Nwd wynosi {0}", nwd);


//**********************************************
// nazwa funkcji: Nwd
// opis funkcji: liczy najwyższy wspólny dzielnik dwóch podanych liczb
// parametry: a - pierwszy czynnik
// b - drugi czynnik
// zwracany typ i opis: (int) najwyższy wspólny dzielnik
// autor: 012345
//***********************************************
int Nwd(int a, int b)
{
    while (a != b)
    {
        if (a > b) a -= b;
        else b -= a;
    }
    return a;
}

