using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1.EsempiDemo
{
    class EsercizioCompleto
    {
        public static void EsempioCalcoloAreePerimetri()
        {
            int operazione = 0;
            string figuraGeometrica = "";
            do
            {
                //EsercizioCompleto.SchermoMenu(ref operazione);
                operazione = EsercizioCompleto.SchermoMenu();
                EsercizioCompleto.AnalizzaScelta(operazione, ref figuraGeometrica);
            } while (operazione != 4);
        }

        public static void AnalizzaScelta(int operazione, ref string figuraGeometrica)
        {
            
            switch (operazione)
            {
                case 1:
                    //TODO: Chiama un metodo per scegliere la figura geometrica
                    EsercizioCompleto.MenuSceltaFigura(ref figuraGeometrica);
                    break;
                case 2:
                    //TODO: calcola il perimetro della figura geometrica
                    double perimetro = EsercizioCompleto.CalcolaPerimetro(figuraGeometrica);
                    Console.WriteLine("Il perimetro della figura geometrica {0} è {1}",
                        figuraGeometrica, perimetro);
                    break;
                case 3:
                    //TODO: calcola l'area della figura geometrica
                    EsercizioCompleto.CalcolaArea(figuraGeometrica);
                    break;
                default:
                    break;
            }
        }

        public static void CalcolaArea(string figuraGeometrica)
        {
            double area = 0.0;
            if(figuraGeometrica == "quadrato")
            {
                Console.WriteLine("Inserisci il lato");
                double lato = Convert.ToDouble(Console.ReadLine());
                area = lato * lato; //Math.Pow(lato, 2);
            } else if(figuraGeometrica == "triangolo")
            {
                Console.WriteLine("Insersci base del triangolo");
                double baseT = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inserisci altezza del triangolo");
                double altT = Convert.ToDouble(Console.ReadLine());
                area = (baseT * altT) / 2;
            } else
            {
                Console.WriteLine("Inserisci base del rettangolo");
                double baseR = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Inserisci altezza del rettangolo");
                double altR = Convert.ToDouble(Console.ReadLine());
                area = (baseR * altR);
            }
            
            Console.WriteLine("L'area della figura geometrica {0} è {1}", figuraGeometrica, area);
        }

        public static double CalcolaPerimetro(string figuraGeometrica)
        {
            double perimetroCalcolato = 0.0;
            double lato, lato2, lato3;

            switch (figuraGeometrica)
            {
                case "quadrato":
                    Console.WriteLine("Inserisci il lato del quadrato");
                    lato = Convert.ToDouble(Console.ReadLine());
                    perimetroCalcolato = lato * 4;
                    break;
                case "triangolo":
                    Console.WriteLine("Inserisci il primo lato");
                    double lato1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il secondo lato");
                    lato2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci il terzo lato");
                    lato3 = Convert.ToDouble(Console.ReadLine());
                    perimetroCalcolato = lato1 + lato2 + lato3;
                    break;
                case "rettangolo":
                    Console.WriteLine("Inserisci l'altezza");
                    double h = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Inserisci la larghezza");
                    double l = Convert.ToDouble(Console.ReadLine());
                    perimetroCalcolato = (h + l) * 2;
                    break;
                case "":
                    Console.WriteLine("Scegli prima la figura geometrica");
                    break;
            }
            
            return perimetroCalcolato;
        }

        public static void MenuSceltaFigura(ref string figura)
        {
            Console.WriteLine("Scegli la figura geometrica");
            Console.WriteLine("1. Quadrato");
            Console.WriteLine("2. Triangolo");
            Console.WriteLine("3. Rettangolo");
            int sceltaFigura = Convert.ToInt32(Console.ReadLine());
            if(sceltaFigura == 1)
            {
                figura = "quadrato";
            } else if(sceltaFigura == 2)
            {
                figura = "triangolo";
            } else
            {
                figura = "rettangolo";
            }
        }

        public static void SchermoMenu(ref int scelta)
        {            
            Console.WriteLine("1. Scegli la figura geometrica");
            //... ecc
            scelta = Convert.ToInt32(Console.ReadLine());
        }
        public static int SchermoMenu()
        {
            int scelta;
            Console.WriteLine("--- Menù ---");
            Console.WriteLine("1. Scegli la figura geometrica");
            Console.WriteLine("2. Calcola il perimetro");
            Console.WriteLine("3. Calcola l'area");
            Console.WriteLine("4. Esci");
            scelta = Convert.ToInt32(Console.ReadLine());
            return scelta;
        }
    }
}
