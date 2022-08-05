using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cypres
{
    internal class ClassCypres
    {
        public static void DessinerCypres(int tailleCypres)
        {
            DessinerCorpsCypres(tailleCypres);
            DessinerPiedCypres(tailleCypres);
        }
        public static int DemanderTaille()
        {

            int inputTaille;
            bool resultat;
            do
            {

                Console.WriteLine("Taille du Cyprès ?");
                string input = Console.ReadLine();
                resultat = int.TryParse(input, out inputTaille);
                if (resultat == false)
                {
                    Console.WriteLine("Tappez un nombre de branches!");
                }

            } while (resultat == false);
            return inputTaille;
        }

        private static void DessinerCorpsCypres(int pCorpsCypres)
        {
            for (int i = 0; pCorpsCypres > i; i++)
            {
                Console.WriteLine("");
                Console.Write("*****");

            }

        }

        private static void DessinerPiedCypres(int pTailleCypres)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                DessinerEspace(pTailleCypres);
                Console.WriteLine("***");
            }

        }

        private static void DessinerEspace(int pEspace)
        {
            Console.Write(' ');
        }
    }
}
