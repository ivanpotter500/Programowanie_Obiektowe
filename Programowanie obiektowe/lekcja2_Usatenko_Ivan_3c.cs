//zadanie 1
using System.Reflection.Metadata;

string dane = "";
dane += "Imię: Ivan\n";
dane += "Nazwisko: Usatenko\n";
dane += "Adres: Jasminowa 16/8\n";

Console.WriteLine(dane);

//zadanie 2

Console.WriteLine("Podaj bok A");
double bok_a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj bok H");
double bok_h = double.Parse(Console.ReadLine());

double formula = 0.5;

double p = (formula * bok_a * bok_h);
p = Math.Round(p, 2);
Console.WriteLine($"Wynik wynosi: {p}");

//zadanie 3
Console.WriteLine("Sprawdz czy liczba jest parzysta");
int liczba_parzysta = int.Parse(Console.ReadLine());

if (liczba_parzysta % 2 == 0)
{
    Console.WriteLine("Liczba jest parzysta");
}
else
{
    Console.WriteLine("Liczba jest nieparzysta");
}

//zadanie 4
Console.WriteLine("Podaj liczbe 1");
int liczba_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe 2");
int liczba_2 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbe 3");
int liczba_3 = int.Parse(Console.ReadLine());

if (liczba_1 > liczba_2 && liczba_1 > liczba_3)
{
    Console.WriteLine($"Najwieksza liczba to: {liczba_1}");
}
else if (liczba_2 > liczba_3 && liczba_2 > liczba_1)
{
    Console.WriteLine($"Najwieksza liczba to: {liczba_2}");
}
else if (liczba_3 > liczba_2 && liczba_3 > liczba_1)
{
    Console.WriteLine($"Najwieksza liczba to: {liczba_3}");
}

//zadanie 5
Console.WriteLine("Podaj bok1");
int bok1 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj bok2");
int bok2 = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj bok3");
int bok3 = int.Parse(Console.ReadLine());

if(bok1 == bok2 && bok2 == bok3)
{
    Console.WriteLine("Trojkat jest rownobocznym");
}
else if (bok1 == bok2 || bok2 == bok3 || bok1 == bok3)
{
    Console.WriteLine("Trojkat jest rownoboczny");
}
else
{
    Console.WriteLine("Trojkat jest roznobocznym");
}

//zadanie 6
Console.WriteLine("Podaj wspolczynnik a");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wspolczynnik b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wspolczynnik c");
double c = double.Parse(Console.ReadLine());

double delta = (b * b) - (4 * a * c);

if (delta == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Jedno rozwiazanie: {x}");
}
else if (delta > 0)
{
    double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"Dwa rozwiazania: {x1} i {x2}");
}