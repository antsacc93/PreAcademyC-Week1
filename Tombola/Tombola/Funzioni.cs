using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombola
{
    class Funzioni
    {

        public static int[] SceltaNumeri(int numeriDisponibili)
        {
            int[] numeriUtente = new int[numeriDisponibili];

            for(int i = 0; i < numeriDisponibili; i++)
            {
                Console.WriteLine("Inserisci il numero {0}/{1}", i + 1, numeriDisponibili);
                
                //numeriUtente[i] = Convert.ToInt32(Console.ReadLine());

                bool success = Int32.TryParse(Console.ReadLine(), out int result);
                numeriUtente[i] = result;

                if (success == false || (result < 0 || result > 100))
                {
                    Console.WriteLine("Inserisci un numero tra 0 e 100");
                    i--;
                }
            }

            return numeriUtente;
        }

        public static int SceltaDifficolta()
        {
            int numeriEstratti = 0;
            char scelta;
            Console.WriteLine("Scegli la difficoltà");
            Console.WriteLine("1. Facile");
            Console.WriteLine("2. Medio");
            Console.WriteLine("3. Difficile");
            scelta = (char)Console.ReadKey().Key;

            switch (scelta)
            {
                case '1':
                    numeriEstratti = 70;
                    break;
                case '2':
                    numeriEstratti = 40;
                    break;
                case '3':
                    numeriEstratti = 20;
                    break;
                default:
                    Console.WriteLine("Scegli tra le opzioni disponibili");
                    break;
            }
            return numeriEstratti;
        }

        public static ArrayList Estrazione(int numeriEstratti, int[] numeriUtente)
        {
            ArrayList numeriCorrispondenti = new ArrayList();
            Random numeroRandom = new Random();
            ArrayList estrazione = new ArrayList();

            for(int i = 0; i < numeriEstratti; i++)
            {
                int numeroEstratto = numeroRandom.Next(0, 101);
                if (estrazione.Contains(numeroEstratto))
                {
                    i--;
                }else
                {
                    if(Array.IndexOf(numeriUtente, numeroEstratto) > 0)
                    {
                        numeriCorrispondenti.Add(numeroEstratto);
                    }
                    estrazione.Add(numeriEstratti);
                }
            }
            return numeriCorrispondenti;
        }

        public static void ControlloVincita(ArrayList numeriVincenti)
        {
            int num = numeriVincenti.Count;
            switch (num)
            {
                case 3:
                    Console.WriteLine("Hai fatto terna!");
                    break;
                case 4:
                    Console.WriteLine("Hai fatto quaterna");
                    break;
                case 5:
                    Console.WriteLine("Hai fatto cinquina");
                    break;
                default:
                    Console.WriteLine("Hai perso");
                    break;
            }
        }

        public static void StampaNumeriCorrispondenti(ArrayList numeriVincenti)
        {
            Console.WriteLine("Ecco i numeri vincenti");
            foreach(var num in numeriVincenti)
            {
                Console.Write(" {0} ", num);
            }
        }
    }
}
