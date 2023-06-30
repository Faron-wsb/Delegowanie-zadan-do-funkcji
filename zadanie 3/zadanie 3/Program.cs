using System;

class Program
{
    static void Main()
    {
        int[] liczby = { 5, 2, 9, 1, 7, 3, 8, 6, 4 };
        int mediana = ObliczMedianę(liczby);
        Console.WriteLine($"Mediana: {mediana}");
    }

    static int ObliczMedianę(int[] tablica)
    {
        int rozmiar = tablica.Length;
        int[] posortowanaTablica = new int[rozmiar];
        Array.Copy(tablica, posortowanaTablica, rozmiar);
        Array.Sort(posortowanaTablica);

        int indeksSrodkowy = rozmiar / 2;

        if (rozmiar % 2 == 0)
        {
            int mediana1 = posortowanaTablica[indeksSrodkowy - 1];
            int mediana2 = posortowanaTablica[indeksSrodkowy];
            return (mediana1 + mediana2) / 2;
        }
        else
        {
            return posortowanaTablica[indeksSrodkowy];
        }
    }
}
