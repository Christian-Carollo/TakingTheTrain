
using System.Collections.Generic;
using TakingTheTrain;


internal static class LinkedListExtensions
{
    public static void GetPercorso<Stazione>(this LinkedList<Stazione> percorsoFerroviario)
    {
        foreach (var elemento in percorsoFerroviario)
        {
            Console.WriteLine(elemento + "\n");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {

        LinkedList<Stazione> percorsoFerroviario = new LinkedList<Stazione>();

        percorsoFerroviario.AddLast(new Stazione("Palermo"));
        percorsoFerroviario.AddLast(new Stazione("Catania"));
        percorsoFerroviario.AddLast(new Stazione("Trapani"));

        Console.WriteLine("Le stazioni presenti nell'iter ferroviario sono:\n");

        percorsoFerroviario.GetPercorso();

        percorsoFerroviario.RemoveFirst();
        percorsoFerroviario.RemoveLast();



        Console.WriteLine("Le stazioni presenti nell'iter ferroviario sono:\n");

        percorsoFerroviario.GetPercorso();

    }
}