using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NomiAnimali_Mariani
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dim = 100;
            string[] array = new string[dim];
            int scelta;
            int pos = 0;
            string parola;

            do 
            {
                Console.Clear();
                Console.WriteLine("Premere uno dei seguenti tasti per selezionare l'operazione desiderata: \n\t1 - Aggiunta di un nome \n\t2 - Cancellazione del singolo nome \n\t3 - Ordinamento dei nomi (bubble sort) \n\t4 - Ricerca sequenziale \n\t5 - Visualizza nomi ripetuti con numero ripetizioni \n\t6 - Modifica di un nome \n\t7 - Visualizzazione di tutti i nomi presenti \n\t8 - Ricerca del nome più lungo e più corto \n\t9 - Cancellazione di tutte le occorrenze di un nome \n\t0 - Uscita");
                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1: // Funzione Inserimento
                        Console.WriteLine("Inserire il nome di animale da aggiungere");
                        parola = Console.ReadLine();
                        Inserimento(ref array, parola, ref pos);
                        break;
                    case 2: // Funzione Cancellazione
                        Console.WriteLine("Inserire il nome di animale da cancellare");
                        parola = Console.ReadLine();
                        Cancellazione(ref array, parola);
                        break;
                    case 3: // Funzione Ordinamemto Nomi (Bubble Sort)
                        BubbleSort(ref array);
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                }
                
                for (int i = 0; i < dim; i++) Console.Write(array[i]);
                Console.WriteLine("Premere un pulsante per continuare...");
                Console.ReadLine();
                
            } while (scelta != 0);
        }

        private static void Inserimento(ref string[] array, string parola, ref int posizione)
        {
            array[posizione] = parola;
            posizione++;
        }

        private static void Cancellazione(ref string[] array, string parola)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == parola)
                {
                    int b = i;
                    while (b < array.Length - 1)
                    {
                        array[b] = array[b + 1];
                        b++;
                    }
                }
            }
        }

        private static void BubbleSort(ref string[] vett)
        {

        }
        
    }
}
