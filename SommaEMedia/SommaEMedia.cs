namespace SommaEMedia;

public class SommaEMedia
{
    public static void Run()
    {
        Console.WriteLine("Inserisci il numero di numeri:");
        int dimensione = int.Parse(Console.ReadLine());
        int[] numeri = new int[dimensione];

        for(int i = 0; i < dimensione; i++)
        {
            Console.WriteLine($"Inserisci il numero {i + 1}:");
            numeri[i] = int.Parse(Console.ReadLine());
        }

        int somma = 0;
        foreach(var numero in numeri)
        {
            somma += numero;
        }

        double media = (double)somma/dimensione;

        Console.WriteLine($"Somma: {somma}");
        Console.WriteLine($"Media: {media}");
    }
}
