//zadanie 1
using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("Podaj swoj wiek (ile bedziesz mial za 10 lat)");
int wiek = int.Parse(Console.ReadLine());
Console.WriteLine($"Bedziesz mial {wiek} lat");

//zadanie 2
Console.WriteLine("Podaj dlugosc prostokata");
int dlugosc_a = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj szerokosc prostokata");
int szerokosc_b = int.Parse(Console.ReadLine());

int pole = dlugosc_a * szerokosc_b;
int obwod = 2 * (dlugosc_a + szerokosc_b);
Console.WriteLine($"Pole prostokata wynosi {pole}");
Console.WriteLine($"Obwod prostokata wynosi {obwod}");

//zadanie 3
Console.WriteLine("Napisz liczbe 1");
int first_number  = int.Parse(Console.ReadLine());
Console.WriteLine("Napisz liczbe 2");
int second_number = int.Parse(Console.ReadLine());

int suma = first_number + second_number;
int roznica = first_number - second_number;
int iloczyn = first_number * second_number;
int iloraz = first_number / second_number;
int reszta_z_dzielenia = first_number % second_number;

Console.WriteLine($"Wynik z sumy jest {suma}");
Console.WriteLine($"Wynik z roznicy jest {roznica}");
Console.WriteLine($"Wynik z iloczyn jest {iloczyn}");
Console.WriteLine($"Wynik z iloraz jest {iloraz}");
Console.WriteLine($"Wynik z reszty_z_dzielenia jest {reszta_z_dzielenia}");

//zadanie 4
Console.WriteLine("Napisz liczbe 1");
int liczba_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Napisz liczbe 2");
int liczba_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Napisz liczbe 3");
int liczba_3 = int.Parse(Console.ReadLine());

int srednia_arytmetyczna = liczba_1 + liczba_2 + liczba_3 / 3;

Console.WriteLine($"Srednia arytmetyczna wynosi: {srednia_arytmetyczna}");

//zadanie 5
Console.WriteLine("Podaj temperature w celsjuszach, zeby skonwertowac w faryngejty, C -> F");
float temperatura = float.Parse(Console.ReadLine());
float f = (temperatura * 9 / 5) + 32;
Console.WriteLine($"Temperatura w farengejtach wynosi: {f} F" );

//zadanie 6
Console.WriteLine("Napisz liczbe 1");
float liczba_pierwsza  = float.Parse(Console.ReadLine());
Console.WriteLine("Napisz liczbe 2");
float liczba_druga = float.Parse(Console.ReadLine());
Console.WriteLine("Podaj znak dzialania");
string znak_dzialania = Console.ReadLine();

if(znak_dzialania == "+")
{
    float odpowiedz = liczba_pierwsza + liczba_druga;
    Console.WriteLine($"Wynik wynosi {odpowiedz}");
}
else if (znak_dzialania == "-")
{
    float odpowiedz = liczba_pierwsza - liczba_druga;
    Console.WriteLine($"Wynik wynosi {odpowiedz}");
}
else if (znak_dzialania == "*")
{
    float odpowiedz = liczba_pierwsza * liczba_druga;
    Console.WriteLine($"Wynik wynosi {odpowiedz}");
}
else if (znak_dzialania == "/")
{
    float odpowiedz = liczba_pierwsza / liczba_druga;
    Console.WriteLine($"Wynik wynosi {odpowiedz}");
}