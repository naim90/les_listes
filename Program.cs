using System;
using System.Collections.Generic;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringCollection = new List<string>
            {"Je vais aller dormir",
            "toto va mal",
            "JP va dormir",
            };

            foreach (string affichageListe0 in stringCollection)
            {
                Console.WriteLine(affichageListe0);
            }

            Console.WriteLine("\n\n");

            stringCollection.RemoveAt(0);

            foreach (string affichageListe1 in stringCollection)
            {
                Console.WriteLine(affichageListe1);
            }
            Console.WriteLine("\n\n");

            stringCollection.Remove("JP va dormir");

            foreach (string affichageListe2 in stringCollection)
            {
                Console.WriteLine(affichageListe2);
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Entrer la phrase qui remplacera la ligne 2 de la liste :\n");
            string phrase = Console.ReadLine();
            stringCollection[0] = phrase;
            Console.WriteLine("\n\n");

            foreach (string affichageListe in stringCollection)
            {
                Console.WriteLine(affichageListe);
            }

        }


        }
    }

