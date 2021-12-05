using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            // saisie du nombre de cases du vectuer
            Console.Write("nombre de cases = ");
            int nb = int.Parse(Console.ReadLine());

            // declaration du vecteur
            int[] vec = new int[nb];

            //saisie du vecteur
            for (int k = 0; k < nb; k++)
            {
                Console.Write("nombre n°" + k + " = ");
                vec[k] = int.Parse(Console.ReadLine());
            }

            // premier affichage du vecteur non trie
            for (int k = 0; k < nb; k++)
            {
                Console.Write(vec[k] + " ");
            }

            //tri par selection
            for (int i = 0; i < nb - 1; i++)
            {
                // recherche de la position du plus petit element
                int numcase = i;
                for (int j = i + 1; j < nb; j++)
                {
                    if (vec[j] < vec[numcase])
                    {
                        numcase = j;
                    }
                }
                //echange des 2 cases
                int sauv = vec[numcase];
                vec[numcase] = vec[i];
                vec[i] = sauv;

                // affichage du vecteur en cours de trie
                Console.WriteLine();
                for (int k = 0; k < nb; k++)
                {
                    Console.Write(vec[k] + " ");
                }

            }

            Console.ReadLine();
        }
    }
}