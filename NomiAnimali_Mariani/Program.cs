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

            do 
            {
                Console.Clear();
                Console.WriteLine("Premere uno dei seguenti tasti per selezionare l'operazione desiderata: \n\t1 - Aggiunta di un nome \n\t2 - Cancellazione del singolo nome \n\t3 - Ordinamento dei nomi (bubble sort) \n\t4 - Ricerca sequenziale \n\t5 - Visualizza nomi ripetuti con numero ripetizioni \n\t6 - Modifica di un nome \n\t7 - Visualizzazione di tutti i nomi presenti \n\t8 - Ricerca del nome più lungo e più corto \n\t9 - Cancellazione di tutte le occorrenze di un nome \n\t0 - Uscita");
                scelta = int.Parse(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Console.WriteLine("Inserire il nome di animale da aggiungere");
                        string parola = Console.ReadLine();
                        Inserimento(ref array, parola, ref pos);
                        break;
                    case 2:
                        break;
                    case 3:
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
                
                Console.WriteLine("Premere un pulsante per continuare...");
                char c = char.Parse(Console.ReadLine());
                
            } while (scelta != 0);
        }

        private static void Inserimento(ref string[] array, string parola, ref int posizione)
        {
            array[posizione] = parola;
            posizione++;
        }

        private static void BubbleSort(int[] vett)
        {
            int temp = 0; //variabile temporanea per lo scambio degli elementi
            int flag = 0; //variabile di controllo sul ciclo esterno
            int n = vett.Length; //variabile inizializzata alla dimensione dell'array
            int p = vett.Length; //variabile per fermarsi al punto del ciclo precedente
            do
            {
                flag = 0; //reiniziallizzo a zero il flag
                for (int i = 0; i < (n - 1); i++)
                    if (vett[i] > vett[i + 1])
                    {
                        temp = vett[i];
                        vett[i] = vett[i + 1];
                        vett[i + 1] = temp;
                        flag = 1; //se avviene lo scambio modifico il valore del flag
                        p = i + 1; //assegno a p il valore del punto in cui avviene lo scambio
                    }
                n = p; //assegno ad n (lunghezza array) il valore di p per interrompere in questo punto
            }
            while (flag == 1);
        }    
    }
}
