﻿using System;
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
                    case 4: // Funzione Ricerca Sequenziale
                        Console.WriteLine("Inserire il nome di animale da ricercare");
                        parola = Console.ReadLine();
                        int ricseq = RicercaSequenziale(ref array, parola);
                        if (ricseq == -1)
                        {
                            Console.WriteLine("La parola non è stata trovata");
                        }
                        else
                        {
                            Console.WriteLine("La parola è stata trovata in posizione " + ricseq+1);
                        }
                        break;
                    case 5: // Funzione Nomi Ripetuti
                        NomiRipetuti(ref array);
                        break;
                    case 6: // Funzione Modifica Nome
                        Console.WriteLine("Inserisci il nome che vuoi modificare");
                        parola = Console.ReadLine();
                        Console.WriteLine("Inserisci il nome che vuoi assegnare");
                        string parolaGiusta = Console.ReadLine();
                        ModificaNome(ref array, parola, parolaGiusta);
                        break;
                    case 7: // Funziona Visualizzare Nomi
                        Visualizza(array);
                        break;
                    case 8: // Funzione Ricerca Nome Lungo e Nome Corto
                        NomeLungoNomeCorto(array);
                        break;
                    case 9:
                        break;
                }
                
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

        private static int RicercaSequenziale(ref string[] array, string parola)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(parola))
                {
                    return i;
                }
            }
            return -1;
        }

        private static void NomiRipetuti(ref string[] array)
        {

        }
        private static void ModificaNome(ref string[] array, string parola, string parolaGiusta)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(parola))
                {
                    array[i] = parolaGiusta;
                    break;
                }
            }
        }

        private static void Visualizza(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                Console.WriteLine(array[i]);
            }
        }
        private static void NomeLungoNomeCorto(string[] array)
        {
            string NomeCorto="", NomeLungo="";
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i].Length >= array[j].Length)
                    {
                        NomeLungo = array[i];
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i].Length <= array[j].Length)
                    {
                        NomeCorto = array[i];
                    }
                }
            }
            
            Console.WriteLine("Il nome più corto è " + NomeCorto);
            Console.WriteLine("Il nome più corto è " + NomeLungo);
        }

        private static void BubbleSort(ref string[] vett)
        {
            int x, y;
            string temp;
            for (x = 0; x < vett.Length - 1; x++)                     // ripeti per tutti i numeri
            {
                for (y = 0; y < vett.Length - 1; y++)                 // li confronto tutti a coppie
                    if (string.Compare(vett[y],vett[y+1]) == 1)//vet[y] > vet[y + 1])                        // se ne trovo uno maggiore
                    {
                        temp = vett[y];                          // li scambio tra loro
                        vett[y] = vett[y + 1];
                        vett[y + 1] = temp;
                    }                                               // fine scambio
            }
        }
    }
}
