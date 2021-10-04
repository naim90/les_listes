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

            Console.WriteLine("\n1-Supprimer la première avec RemoveAt\n2-Supprimer la 3ème avec Remove\n3-Modifier la deuxième avec son indice :\n");
            int choix = Convert.ToInt32(Console.ReadLine());
            Program.Liste(stringCollection,choix);
        }

        public static void Liste(List<string> stringCollection,int a)
        {


            if (a == 1)
            {
                stringCollection.RemoveAt(0);

                foreach (string affichageListe1 in stringCollection)
                {
                    Console.WriteLine(affichageListe1);
                }
            }

            if (a == 2)
            {
                stringCollection.Remove("JP va dormir");

                foreach (string affichageListe2 in stringCollection)
                {
                    Console.WriteLine(affichageListe2);
                }
            }

            if (a == 3)
            {
                Console.WriteLine("Entrer la phrase qui remplacera la ligne 2 de la liste :\n");
                string phrase=Console.ReadLine();
                stringCollection[1] = phrase;

                foreach (string affichageListe in stringCollection)
                {
                    Console.WriteLine(affichageListe);
                }
            }

        }
    }
}
