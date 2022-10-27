using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Aufgabe_____Führe Berechnungen auf Werten des Array durch und sortiere die Werte danach*/

            Console.WriteLine("ConsoleArrayFIA");
            Console.WriteLine();
            int endCounter = 0;
            while (endCounter != 1)
            {
                Console.Write("Arraylänge: ");
                int array__Length = Convert.ToInt32(Console.ReadLine());
                int[] array__Fia = new int[array__Length];
                Fill(array__Fia);
                Show(array__Fia, " ");
                Console.WriteLine("Summe: " + Summe(array__Fia));
                Console.WriteLine("Mittel gerundet: " + Mittel(array__Fia));
                Console.WriteLine("Max: " + Max(array__Fia));
                Console.WriteLine("Min: " + Min(array__Fia));
                Console.WriteLine();
                Console.WriteLine("Array sortiert");
                Show(Sort(array__Fia), " ");

                int j = 0;
                while (j == 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Programm beenden? Ja / Nein: ");
                    string str = Console.ReadLine();
                    Console.WriteLine();
                    switch (str.ToUpper())
                    {
                        case "JA":
                            endCounter = 1;
                            j = 1;
                            break;
                        case "NEIN":
                            endCounter = 0;
                            j = 1;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
                            j = 0;
                            continue;
                    }
                }
            }



            /*Aufgabe_____Befüllen sie ein 2-dimensionales Array*/

            //Console.WriteLine("ConsoleArray2Dim");
            //Console.WriteLine();
            //int endCounter = 0;
            //while (endCounter != 1)
            //{
            //    Console.WriteLine("Bitte erste Größe für das 2-dimensionales Array eingeben: ");
            //    int arrayX = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Bitte zweite Größe für das 2-dimensionales Array eingeben: ");
            //    int arrayY = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Console.WriteLine("Fortlaufende Werte in das Array schreiben und anzeigen. ");

            //    int[,] array = new int[arrayX, arrayY];
            //    int l = 1;
            //    for (int i = 0; i < arrayX; i++)
            //    {
            //        Console.WriteLine();
            //        for (int k = 0; k < arrayY; k++)
            //        {

            //            array [i, k] = l;
            //            Console.Write(" " + array[i, k]);
            //            l++;
            //        }
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    int j = 0;
            //    while (j == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Programm beenden? Ja / Nein: ");
            //        string str = Console.ReadLine();
            //        Console.WriteLine();
            //        switch (str.ToUpper())
            //        {
            //            case "JA":
            //                endCounter = 1;
            //                j = 1;
            //                break;
            //            case "NEIN":
            //                endCounter = 0;
            //                j = 1;
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
            //                j = 0;
            //                continue;
            //        }
            //    }
            //}



            /*Aufgabe_____Führen sie eine bestimmte Anzahl Würfelwürfe durch und zählen sie wie oft ein Wert gewürfelt wurde*/

            //Console.WriteLine("ConsoleArrayWürfelsimulation");
            //Console.WriteLine();
            //int endCounter = 0;
            //while (endCounter != 1)
            //{
            //    Console.Write("Wieviele Würfe sollen ausgeführt werden? ");
            //    int nWürfe = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine();
            //    Random random = new Random();
            //    int[] arAugenzahlen = new int[7];
            //    int[] arAugenzahlen2 = new int[nWürfe];
            //    int a = 0;
            //    for (int l = 0; l < nWürfe; l++)
            //    {
            //        arAugenzahlen2[l] = random.Next(1, 7);
            //        Console.Write(" " + arAugenzahlen2[l]);
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //    for (int i = 0; i < nWürfe; i++)
            //    {
            //        a = arAugenzahlen2[i];
            //        switch (a)
            //        {
            //            case 1:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //            case 2:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //            case 3:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //            case 4:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //            case 5:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //            case 6:
            //                arAugenzahlen[a] = arAugenzahlen[a] + 1;
            //                break;
            //        }
            //    }
            //    Console.WriteLine("Statistik:");
            //    Console.WriteLine();
            //    Console.WriteLine("Es wurden " + nWürfe + " Würfe ausgeführt.");
            //    Console.WriteLine();
            //    for (int k = 1; k < arAugenzahlen.Length; k++)
            //    {
            //        Console.WriteLine("Augenzahl " + k + " kommt " + arAugenzahlen[k] + " mal vor");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();

            //    int j = 0;
            //    while (j == 0)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.Write("Programm beenden? Ja / Nein: ");
            //        string str = Console.ReadLine();
            //        Console.WriteLine();
            //        switch (str.ToUpper())
            //        {
            //            case "JA":
            //                endCounter = 1;
            //                j = 1;
            //                break;
            //            case "NEIN":
            //                endCounter = 0;
            //                j = 1;
            //                break;
            //            default:
            //                Console.ForegroundColor = ConsoleColor.White;
            //                Console.WriteLine("Falsche Eingabe. Bitte geben Sie Ja oder Nein ein.");
            //                j = 0;
            //                continue;
            //        }
            //    }
            //}
        }

        public static void Fill(int[] ar)
        {
            var rand = new Random();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = rand.Next(100);
            }
        }

        public static void Show(int[] ar, string description = "")
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + description);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int Summe(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            return sum;
        }

        public static int Mittel(int[] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            int mittel = sum / ar.Length;
            return mittel;
        }
        public static int Max(int[] ar)
        {
            int arMax = ar.Max();
            return arMax;
        }

        public static int Min(int[] ar)
        {
            int arMin = ar.Min();
            return arMin;
        }

        public static int[] Sort(int[] ar)
        {
            for (int i = 0; i < ar.Length - 1; i++)
            {
                int a = ar[i];
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[j] < a)
                    {
                        a = ar[j];
                        ar[j] = ar[i];
                        ar[i] = a;
                    }
                }
            }
            return ar;
        }
    }
}

