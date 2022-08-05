using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapin
{
    internal static class ClassSapin
    {
        public static void DessinerSapin(int dessinerSapin)
        {
            DessinerCorpsSapin(dessinerSapin);
            DessinerPiedSapin(dessinerSapin);
        }

        public static int DemanderTaille()
        {

            int inputTaille;
            bool resultat;
            do
            {

                Console.WriteLine("Taille du sapin ?");
                string input = Console.ReadLine();
                resultat = int.TryParse(input, out inputTaille);
                if (resultat == false)
                {
                    Console.WriteLine("Tappez un nombre de branches!");
                }

            } while (resultat == false);
            return inputTaille;
        }

        private static void DessinerPiedSapin(int pTailleSapin)
        {
            for (int i = 0; i < 3; i++)
            {
                DessinerEspace(pTailleSapin - 2);
                Console.WriteLine("***");
            }

        }

        private static void DessinerCorpsSapin(int pCorpsSapin)
        {
            for (int i = 1; i <= pCorpsSapin; i++)
            {

                DessinerEspace(pCorpsSapin - i);
                for (int k = 0; k < (i * 2) - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

        private static void DessinerEspace(int pEspace)
        {
            int i = 0;
            for (int j = 0; j < pEspace - i; j++)
            {
                Console.Write(" ");
            }
        }


    }
}

