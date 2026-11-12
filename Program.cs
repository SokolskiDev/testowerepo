
int a = StrToInt("Podaj a");
int b = StrToInt("Podaj b");

Console.WriteLine($"Pole prostokąta: {a*b}cm^2");

int s = Silnia(StrToInt("Podaj s"));
Console.WriteLine($"Silnia: {s}");
int s1 = StrToInt("Podaj s1");
int wynik = 1;
for (int i = 2; i <= s1; i++)
{
    wynik *= i;
}
Console.WriteLine($"Silnia z fora: {wynik}");
int Silnia(int a)
{
    if (a > 1)
    {
        return a * Silnia(a - 1);
    }
    else
        return 1;
}
int StrToInt(string tekst)
{
    while (true)
    {
        Console.WriteLine(tekst);
        if (int.TryParse(Console.ReadLine(), out int zmienna))
            return zmienna;
    }
	
}