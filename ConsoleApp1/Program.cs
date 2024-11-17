//zad1

class Program1
{
    static void Main1(string[] args)
    {
        int number1 = 1;
        int number2 = -5;
        int number3 = 0;

        number1 = number1 > 0 ? -number1 : number1;
        number2 = number2 > 0 ? -number2 : number2;
        number3 = number3 > 0 ? -number3 : number3;

        Console.WriteLine(number1);
        Console.WriteLine(number2);
        Console.WriteLine(number3);
    }
}
//zad2

class Program2
{
    static void Main2(string[] args)
    {
        int[] Array1 = { 34, 15, 88, 2 };
        int[] Array2 = { 34, -345, -1, 100 };

        int minArray1 = Array1.Min();
        int minArray2 = Array2.Min();

        Console.WriteLine(minArray1);
        Console.WriteLine(minArray2);
    }
}

//zad3

class Program3
{
    static void Main3(string[] args)
    {
        int[] tablica1 = { 34, 15, 88, 2 };
        int[] tablica2 = { 34, -345, -1, 100 };

        int sumaTablica1 = 0;
        int sumaTablica2 = 0;

        foreach (int liczba in tablica1)
        {
            sumaTablica1 += liczba;
        }

        foreach (int liczba in tablica2)
        {
            sumaTablica2 += liczba;
        }

        int sumaLaczna = sumaTablica1 + sumaTablica2;

        Console.WriteLine("Suma wszystkich elementów w obu tablicach: " + sumaLaczna);
        Console.WriteLine("Suma pierwszej tablicy: " + sumaTablica1);
    }
}


//zad4

class Program4
{
    public static int[] LiczbyDodatnieIUjemne(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            return new int[] { };
        }
        int liczbaDodatnich = 0;
        int sumaUjemnych = 0;
        foreach (var liczba in tablica)
        {
            if (liczba > 0)
            {
                liczbaDodatnich++;
            }
            else if (liczba < 0)
            {
                sumaUjemnych += liczba;
            }
        }
        return new int[] { liczbaDodatnich, sumaUjemnych };
    }

    public static void Main()
    {
        int[] wynik = LiczbyDodatnieIUjemne(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 });
        Console.WriteLine($"[{wynik[0]}, {wynik[1]}]");
    }
}



//zad5

class Program5
{
    public static int[] LiczbyPomiedzy(int a, int b)
    {
        List<int> liczby = new List<int>();
        for (int i = a; i <= b; i++)
        {
            liczby.Add(i);
        }
        return liczby.ToArray();
    }

    public static void Main()
    {
        int a = 1;
        int b = 5;
        int[] wynik = LiczbyPomiedzy(a, b);
        Console.WriteLine($"[{string.Join(", ", wynik)}]");
    }
}

//zad6

class Program6
{
    public static int[] DwieNajwyzszeWartosci(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            return new int[] { };
        }
        var unikalneLiczby = tablica.Distinct().OrderByDescending(x => x).ToArray();

        return unikalneLiczby.Take(2).ToArray();
    }

    public static void Main()
    {
        var wynik1 = DwieNajwyzszeWartosci(new int[] { 4, 10, 10, 9 });
        var wynik2 = DwieNajwyzszeWartosci(new int[] { 1, 1, 1 });
        var wynik3 = Array.Empty<int>;

        Console.WriteLine(wynik1);
        Console.WriteLine(wynik2);
        Console.WriteLine(wynik3);
    }
    public static int[] NajwyzszaWartosc(int[] tablica)
    {
        if (tablica == null || tablica.Length == 0)
        {
            return new int[] { };
        }
        int max = tablica.Max();
        return new int[] { max };
    }
    public static void Main2()
    {
        var wynik11 = NajwyzszaWartosc(new int[] { 4, 10, 10, 9 });
        var wynik22 = NajwyzszaWartosc(new int[] { 1, 1, 1 });
        var wynik33 = Array.Empty<int>();

        Console.WriteLine(wynik11);
        Console.WriteLine(wynik22);
        Console.WriteLine(wynik33);
    }
}

//zad7

class Program7
{
    public static void RysujSchody(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', i));
            Console.WriteLine("I");
        }
    }

    public static void Main()
    {
        Console.ReadLine();
    }
}

//zad8

class Program8
{
    public static int Obliczenia(int dlugosc, int szerokosc)
    {
        if (dlugosc == szerokosc)
        {
            return dlugosc * szerokosc;
        }
        else
        {
            return 2 * (dlugosc + szerokosc);
        }
    }
}
