using System;
using RicercaNome;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Seleziona il programma da eseguire:");
            Console.WriteLine("1: Gestione Conto Corrente");
            Console.WriteLine("2: Ricerca Nome");
            Console.WriteLine("3: Calcolo Somma e Media");
            Console.WriteLine("4: Esci");
            Console.Write("Inserisci la tua scelta: ");

            switch(Console.ReadLine())
            {
                // case "1":
                //     GestioneContoCorrente.Run();
                //     break;
                case "2":
                    RicercaNome.Run();
                    break;
                // case "3":
                //     CalcoloSommaMedia.Run();
                //     break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Scelta non valida! Riprova.");
                    break;
            }
        }
    }
}