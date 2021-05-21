using System;
using System.Collections;

namespace Tombola
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeriDisponibili = 5;
            int numeriEstratti = 0;
            char key;
            Console.WriteLine("Benvenuto a Tombola!");

            do
            {                
                do
                {
                    numeriEstratti = Funzioni.SceltaDifficolta();
                } while (numeriEstratti == 0);

                int[] numeriUtente = Funzioni.SceltaNumeri(numeriDisponibili);

                ArrayList numeriCorrispondenti = Funzioni.Estrazione(numeriEstratti, numeriUtente);

                Funzioni.ControlloVincita(numeriCorrispondenti);
                Funzioni.StampaNumeriCorrispondenti(numeriCorrispondenti);

                Console.WriteLine("Se vuoi uscire premi 'q', altrimenti qualsiasi altro tasto");
                key = Console.ReadKey().KeyChar;
            } while (key != 'q');
        }
    }
}
