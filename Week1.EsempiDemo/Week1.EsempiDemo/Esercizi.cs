using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.EsempiDemo
{
    public class Esercizi
    {

        #region TIPI
        enum Gender
        {
            Male = 3,
            Female,
            Other
        }
        public static void EserciziTipo()
        {
            //Booleano
            //Esercizio per il tipo booleano
            bool x, y, z = false; //dichiarazione + inizializzazione z
            x = true; //assegnazione
            y = false;
            bool w = !y; // la variabile w vale true
            Console.WriteLine("Variabile booleana w:{0}", w);
            Console.WriteLine("Valore di y-x-z: {0} {1} {2}", y, x, z);

            //Int
            int i, j;
            i = 2;
            j = i;
            Console.WriteLine("i vale: {0} - j vale: {1}", i, j);
            //Console.WriteLine("i vale: " + i + " - j vale " + j);
            i = 3;
            Console.WriteLine("i vale: {0} - j vale {1}", i, j);

            //stringhe
            string a = "ciao";
            string b = a;
            //stringa come value type
            Console.WriteLine("La stringa a vale " + a + " la stringa b vale " + b);
            a = "hello";
            Console.WriteLine("La stringa a vale {0} la stringa b vale {1}", a, b);
            //stringa come reference type
            int lunghezzaStringa = a.Length;
            string sottoStringa = a.Substring(0, 2);
            Console.WriteLine("La stringa a è lunga {0}, una sua sottostringa è {1}", lunghezzaStringa, sottoStringa);

            //Decimali
            float numDecimale = 1f;
            Console.WriteLine("Il numero decimale vale {0}", numDecimale);
            double doubl = 1d / 3d;
            decimal dec = 1m / 3m;
            Console.WriteLine("Doppia precisione {0} - Decimal {1}", doubl, dec);

            //Somma +
            //Differenza -
            //Moltiplicazione *
            //Divisione /
            //Resto %

            DateTime dataCorrente = new DateTime(2021, 5, 18);
            DateTime oggi = DateTime.Today;
            DateTime now = DateTime.Now;
            Console.WriteLine("Data corrente: {0}", dataCorrente);
            Console.WriteLine("Oggi: {0}", oggi);
            Console.WriteLine("Proprio ora! {0}", now.TimeOfDay);

            Gender g = Gender.Female;
            Console.WriteLine(g);

            //Operatori
            i += 3; //equivalente  i = i + 3
            i *= 4; //equivalente i = i * 4
            i /= 2; //equivalente a i = i / 2
            i++; // equivalente i = (i + 1) ancora equivalente a i += 1
            i--; // equivalente a i = (i - 1) ancora equivalente a i -= 1
        }

        #endregion

        #region CONDIZIONALI

        //stampare il numero più grande
        public static void Massimo()
        {
            int a = 3;
            int b = 5;
            if (a > b)
            {
                Console.WriteLine("a è il massimo a:{0} b:{1}", a, b);
            } else
            {
                Console.WriteLine("b è il massimo b:{0} a:{1}", b, a);
            }
        }

        public static void MassimoV2()
        {
            int a = 12;
            int b = 15;

            if(a == b)
            {
                Console.WriteLine("a e b sono uguali a:{0} b:{1}", a, b);
            } else if(a > b)
            {
                Console.WriteLine("a è maggiore di b - a:{0} b:{1}", a, b);
            } else
            {
                Console.WriteLine("b è maggiore di a - b:{0} a:{1}", b, a);
            }
        }

        public static void SceltaOperazioneSwitch()
        {
            Console.WriteLine("Scelta dell'operazione da eseguire");
            char q;
            Console.WriteLine("Inserisci due numeri");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Scegli l'operazione aritmetica da eseguire");
            Console.WriteLine("s - Per la somma");
            Console.WriteLine("d - Per la differenza");
            Console.WriteLine("m - Per la moltiplicazione");
            Console.WriteLine("D - Per la divisione");

            q = Console.ReadKey().KeyChar; // assegno alla variabile q una lettera inserita dall'utente

            switch (q)
            {
                case 's':
                    Console.WriteLine("Somma dei due numeri");
                    Console.WriteLine(a + b);
                    break;
                case 'd':
                    Console.WriteLine("Differenza dei due numeri");
                    Console.WriteLine(a - b);
                    break;
                case 'm':
                    Console.WriteLine("Moltiplicazione dei due numeri");
                    Console.WriteLine(a * b);
                    break;
                case 'D':
                    Console.WriteLine("Divisione tra due numeri");
                    Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Operazione non disponibile");
                    break;
            }
        }

        public static void SceltaOperazioneIf()
        {
            Console.WriteLine("Inserisci due numeri");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            char q;

            Console.WriteLine("Inserisci l'operazione da eseguire");
            Console.WriteLine("s - Somma i numeri");
            Console.WriteLine("d - Sottrai i numeri");
            Console.WriteLine("m - Moltiplica i numeri");
            Console.WriteLine("D - Dividi i numeri");
            q = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            if (q == 's')
            {
                Console.WriteLine("\n Somma di due numeri \t {0}", a + b);
            } else if (q == 'd')
            {
                Console.WriteLine("\n Differenza tra due numeri {0}", a - b);
            } else if (q == 'm')
            {
                Console.WriteLine("\n Moltiplicazione tra due numeri {0}", a * b);
            } else if (q == 'D')
            {
                Console.WriteLine("\n Divisione tra due numeri {0}", a / b);
            } else
            {
                Console.WriteLine("\n Operazione non consentita");
            }
        }

        #endregion

        #region CICLI
        public static void EsempioCicloWhile()
        {
            //richiesta di inserimento di un numero
            Console.WriteLine("Inserisci un numero positivo per entrare nel ciclo, " +
                "negativo per uscire");
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine("Hai inserito un numero positivo");
                Console.WriteLine("Inserisci un nuovo numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void EsempioCicloDoWhile()
        {
            //Richiesta di inserimento di un numero
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine("Inserimento di un numero positivo");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num > 0);
        }

        public static void SuccessioneValori()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valore {0}", i);
            }
        }

        public static void SuccessioneValoriWhile()
        {
            Console.WriteLine("Successione valori con While");
            int i = 0;
            while(i < 5)
            {
                Console.WriteLine("Valore {0}", i);
                i++;
            }
        }

        public static void SuccessioneValoriDoWhile()
        {
            Console.WriteLine("Successione valori con Do While");
            int i = 0;
            do
            {
                Console.WriteLine("Valore {0}", i);
                i++; 
            } while (i < 5);
        }

        //  *  
        // ***
        //*****
        public static void Piramide()
        {
            int i, j;
            int n = 3;
            for(i = 1; i <= n; i++)
            {
                for(j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }

                for(j = 1; j <= 2*i - 1; j++)
                {
                    Console.Write("*");
                }
                //Console.WriteLine();
                Console.Write("\n");
            }
        }

        //  *
        // ***
        //*****
        // ***
        //  *
        public static void Rombo()
        {
            int i, j;
            int n = 3;
            for(i = 1; i <= n; i++)
            {
                for(j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= 2*i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for(i = n-1; i >= 1; i--)
            {
                for(j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for(j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        #endregion

        #region SALTI

        public static void Break()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    break;
                }
                Console.WriteLine("Valore: \t {0}", i);
            }
        }

        public static void Continue()
        {
            for(int i = 0; i < 10; i++)
            {
                if(i == 4)
                {
                    continue;                   
                }
                Console.WriteLine("Valore: \t {0}", i);
            }
        }


        #endregion

        #region SOMMA E MEDIA
        public static void SommaMediaNumeri()
        {
            int num;
            int somma = 0;
            double media;
            Console.WriteLine("Quanti numeri vuoi inserire?");
            num = Convert.ToInt32(Console.ReadLine());
            while(num < 0) // verifico che l'utente inserisca un numero positivo
            {
                Console.WriteLine("Inserisci un numero maggiore di zero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            //for(int i = 1; i <= num; i++)
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Inserisci il numero {0}", i + 1);
                //somma += Convert.ToDouble(Console.ReadLine()); // somma = somma + Convert.ToDou...
                somma += Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Hai ottenuto somma {0}", somma);
            //Console.WriteLine("Hai ottenuto media {0}", somma / num);
            media = (double)somma / num;
            Console.WriteLine("Hai ottenuto media {0}", media);
        }
        #endregion

        #region CAST
        public static void Cast()
        {
            //Cast implicito
            byte b = 12;
            int a = b;

            //Cast esplicito
            int j = -10;
            byte p = (byte)j;
            Console.WriteLine("Da int a byte {0}", p);

            int primo = 4;
            string secondo = "12";
            string terzo = primo + secondo;
            Console.WriteLine("Risultato {0}", terzo);
            //trasformo la variabile string 'secondo' in intero e salvo il suo
            //valore nella variabile res
            bool success = Int32.TryParse(secondo, out int res);
            if(success == true) //equivale a if(success) 
            {
                Console.WriteLine("Risultato dopo il cast {0}", primo + res);
            } else
            {
                Console.WriteLine("Errore di conversione");
            }

            //Cast vs Convert
            double num = 1.5;
            int castToInt = (int)num;
            int convertToInt = Convert.ToInt32(num);
            // solo per stringhe bool parseToInt = Int32.TryParse(num, out int res1);
            Console.WriteLine("Double convertito in intero -> {0} - {1}", castToInt, convertToInt);

        }
        #endregion

        #region ARRAY

        public static void EsempioArray()
        {
            //string come array
            string a = "ciao";
            Console.WriteLine("La stringa a contiene {0} caratteri", a.Length);
            Console.WriteLine("La prima lettera della stringa a è {0}", a[0]);

            //Dichiarazione di array
            string[] x = new string[3]; //gli elementi hanno posizioni da 0 a n-1
            x[0] = "Hello ";
            x[1] = "World";
            x[2] = x[0] + x[1];

            //Inizializzazione
            int[] array = new int[] { 1, 2, 3, 4, 5, 3 };
            int[] array2 = {1, 2, 3, 4 };
            Console.WriteLine("Il primo array contiene {0} elementi", array.Length);
            Console.WriteLine("Il secondo array contiene {0} elementi", array2.Length);

            //Recupero di un elemento di un array
            int index = array[2];
            Console.WriteLine("Index: {0}", index);
            //Altro metodo per il recupero della lunghezza
            int lunghezzaArray = array.GetLength(0);
            Console.WriteLine("L'array contiene {0} elementi", lunghezzaArray);
            //Indice
            int indice = Array.IndexOf(array, 3);
            Console.WriteLine("Il 3 è contenuto in posizione {0}", indice);
            int indiceNegativo = Array.IndexOf(array, 15);
            if(indiceNegativo > 0)
            {
                Console.WriteLine("Ho trovato il 15!");
            } else
            {
                Console.WriteLine("Spiacente non ho trovato il numero richiesto");
            }
            Array.Resize(ref array2, 6);
            Console.WriteLine("Array2 contiene ora {0} valori", array2.Length);

            //scansione array con for
            //for(int i = 0; i <= array2.Length - 1; i++)
            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Elemento in posizione {0}: {1}", i + 1, array2[i]);
            }
            Console.WriteLine("Scansione con foreach");
            //scansione dell'array con il foreach
            foreach(int item in array2)
            {
                Console.WriteLine("Elemento in posizione {0}: {1}", Array.IndexOf(array2, item) 
                    + 1, item);
            }
            //stampa elementi in posizione pari
            Console.WriteLine("Elementi pari");
            for(int i = 1; i < array2.Length; i += 2)
            {
                Console.WriteLine("Elemento in posizione {0}: {1}", i + 1, array2[i]);
            }

            //Array multidimensionali
            double[,] multidimensionale = new double[2, 3];
            double[,] matrice = { { 1.3, 2.45, 3.2 }, { 7.1, 8.2, 9.3 } };
            int rank = matrice.Rank;
            int[,,] spazio = new int[3, 3, 3];
            int rank3D = spazio.Rank;
            Console.WriteLine("Dimensioni array {0} - {1}", rank, rank3D);

            //Collection 

            //ArrayList
            ArrayList esempioLista1 = new ArrayList() { };
            ArrayList esempioLista2 = new ArrayList() { 1, 2, 3 };

            for(int i = 0; i < esempioLista2.Count; i++)
            {
                Console.WriteLine("Elemento -> {0}", esempioLista2[i]);
            }

            //Add
            esempioLista2.Add(2);
            esempioLista2.Add("ciao");
            esempioLista2.AddRange(new[] { 5, 9, 12 });

            //Insert
            esempioLista2.Insert(0, "hello");
            esempioLista2.InsertRange(0, new[] { 3.4, 5.6, 7 });
            Console.WriteLine("Dopo una serie di inserimenti... ");
            //foreach(var item in esempioLista2)
            foreach (object item in esempioLista2)
            {
                Console.WriteLine("Item: {0}", item);
            }
            Console.WriteLine("Eliminiamo qualcosa");
            esempioLista2.Remove(12);
            esempioLista2.RemoveAt(0);
            
            foreach(var elem in esempioLista2)
            {
                Console.WriteLine("Elem. {0}", elem);
            }

            bool verify = esempioLista2.Contains("hello");
            if (verify)
            {
                Console.WriteLine("La lista contiene hello");
            } else
            {
                Console.WriteLine("Spiacenti non lo contiene");
            }

            esempioLista2.Clear();
        }

        #endregion

        #region ROUTINE

        public static void MyMethod(int a, int b, ref int c)
        {
            c = a + b;
        }

        public static int MyMethod(int a, int b)
        {
            int risultato = a + b;
            return risultato;
            //return a + b;
        }

        public static bool IsPari(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        //Parametri opzionali
        public static int Moltiplica(int a, int b = 1, int c = 1)
        {
            return a * b * c;
        }

        //Parametri di output
        public static bool SoluzioniEquazioni2Grado(int a, int b, int c, out double[] result)
        {
            double delta = (b * b) - 4 * a * c;
            if(delta >= 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                result = new double[] { x1, x2 };
                return true;
            }
            result = new double[] { 0.0, 0.0 };
            return false;
        }

        public static bool IsAuthorized(string user, string password, out string[] anagrafica)
        {
            if(user == "mrossi" && password == "1234")
            {
                anagrafica = new string[] { "Mario", "Rossi", "50", "Milano" };
                return true;
            }
            anagrafica = new string[] { "", "", "", "" };
            return false;
        }

        public static void EsempiRoutine()
        {
            int x = 0;
            string a;
            Esercizi.MyMethod(2, 3, ref x);
            Console.WriteLine("Valore di x: {0}", x);

            x = Esercizi.MyMethod(2, 3);

            Console.WriteLine("Valore di x dopo la funzione: {0}", x);
            Console.WriteLine("Risultato della funzione {0}", Esercizi.MyMethod(2, 3));

            if (Esercizi.IsPari(x))
            {
                Console.WriteLine("Hai inserito un numero pari!");
            }
            else
            {
                Console.WriteLine("Hai inserito un numero dispari");
            }

            int elem = Esercizi.Moltiplica(2, 3);
            Console.WriteLine("Il valore moltiplicato {0}", elem);

            var sol = Esercizi.SoluzioniEquazioni2Grado(2, 4, 1, out double[] soluzioni);
            if (sol)
            {
                foreach (var item in soluzioni)
                {
                    Console.WriteLine("Soluzione -> {0}", item);
                }
            }
            else
            {
                Console.WriteLine("Non esistono soluzioni reali");
            }

            Console.Clear(); // pulizia della console

            string user = "mrossi";
            var authorized = Esercizi.IsAuthorized(user, "1234", out string[] dati);
            if (authorized)
            {
                Console.WriteLine("Ok, utente {0} autorizzato", user);
                Console.WriteLine("I suoi dati in anagrafica sono");
                foreach (var val in dati)
                {
                    Console.WriteLine(val);
                }
            }
            else
            {
                Console.WriteLine("Accesso negato");
            }
        }

        #endregion
    }
}
