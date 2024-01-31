namespace RicercaNome;

public class RicercaNome
{
    public static void Run()
    {
        Console.WriteLine("Inserisci il numero di nomi:");
        int numeroNomi = int.Parse(Console.ReadLine());
        string[] nomi = new string[numeroNomi];

        for(int i = 0; i < numeroNomi; i++)
        {
            Console.WriteLine($"Inserisci il nome {i + 1}:");
            nomi[i] = Console.ReadLine();
        }

        Console.WriteLine("Inserisci il nome da cercare:");
        string nomeDaCercare = Console.ReadLine();
        bool trovato = false;

        foreach(var nome in nomi)
        {
            if(nome.Equals(nomeDaCercare, StringComparison.OrdinalIgnoreCase))
            {
                trovato = true;
                break;
            }
        }

        if(trovato)
        {
            Console.WriteLine("Nome trovato!");
        } else 
        {
            Console.WriteLine("Nome non trovato!");
        }
    }
}
