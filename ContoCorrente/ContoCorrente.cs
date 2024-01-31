namespace ContoCorrente;

public class ContoCorrente
{
    public string NumeroConto { get; private set; }
    public double Saldo { get; private set; }
    private bool isContoAperto;

    public ContoCorrente(string numeroConto)
    {
        NumeroConto = numeroConto;
        isContoAperto = false;
    }

    public void ApriConto(double primoVersamento)
    {
        if(!isContoAperto && primoVersamento >= 1000)
        {
            Saldo = primoVersamento;
            isContoAperto = true;
        }
        else 
        {
            throw new Exception("Il conto è già aperto o l'importo iniziale non è sufficiente.");
        }
    }

    public void Versamento(double importo)
    {
        if(!isContoAperto)
        {
            throw new InvalidOperationException("Il conto non è aperto.");
        }

        if(importo > 0)
        {
            Saldo += importo;
        }
        else
        {
            throw new ArgumentOutOfRangeException(nameof(importo), "L'importo deve essere positivo.");
        }
    }

    public void Prelievo(double importo)
    {
        if(!isContoAperto)
        {
            throw new InvalidOperationException("Il conto non è aperto.");
        }

        if(importo > 0 && importo <= Saldo)
        {
            Saldo -= importo;
        } else {
            throw new ArgumentOutOfRangeException(nameof(importo), "L'importo deve essere positivo e non superiore al saldo.");
        }
    }

    public void VisualizzaSaldo()
    {
        if(!isContoAperto)
        {
            throw new InvalidOperationException("Il conto non è aperto.");
        }
        Console.WriteLine($"Saldo attuale: {Saldo:C}");
    }

    public static void Run()
    {
       ContoCorrente conto = null;
       Console.WriteLine("Benvenuto in Banca");

       while(true)
        {
            Console.WriteLine("\nScegli un'opzione:");
            Console.WriteLine("1: Apri un nuovo conto");
            Console.WriteLine("2: Effettua un versamento");
            Console.WriteLine("3: Effettua un prelievo");
            Console.WriteLine("4: Visualizza il saldo");
            Console.WriteLine("5: Esci");

            Console.Write("Inserisci il numero dell'opzione: ");
            string opzione = Console.ReadLine();

            switch(opzione)
            {
                case "1":
                    if(conto == null)
                    {
                        Console.WriteLine("Inserisci il numero del conto:");
                        string numeroConto = Console.ReadLine();
                        conto = new ContoCorrente(numeroConto);
                        Console.Write("Inserisci il primo versamento (minimo 1000):");
                        double primoVersamento = double.Parse(Console.ReadLine());
                        conto.ApriConto(primoVersamento);
                    } else
                    {
                        Console.WriteLine("Un conto è già aperto!");
                    }
                    break;
                case "2":
                    if(conto != null)
                    {
                        Console.Write("Inserisci l'importo da versare:");
                        double importoVersamento = double.Parse(Console.ReadLine());
                        conto.Versamento(importoVersamento);
                    } else
                    {
                        Console.WriteLine("Nessun conto aperto!");
                    }
                    break;
                case "3":
                    if(conto != null)
                    {
                        Console.Write("Inserisci l'importo da prelevare:");
                        double importoPrelievo = double.Parse(Console.ReadLine());
                        conto.Prelievo(importoPrelievo);
                    } else 
                    {
                        Console.WriteLine("Nessun conto aperto!"); 
                    }
                    break;
                case "4":
                    if(conto != null)
                    {
                        conto.VisualizzaSaldo();
                    } else
                    {
                        Console.WriteLine("Nessun conto aperto!");
                    }
                    break;
                case "5":
                    Console.WriteLine("Grazie per aver usato questa Banca!");
                    return;
                default:
                    Console.WriteLine("Opzione non valida");
                    break;
            }
        }
    }

    
}
