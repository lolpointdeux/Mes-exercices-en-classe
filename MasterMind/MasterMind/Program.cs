using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez les couleur que vous avez choisit");
            
            int[] combi = new int[4];
            masteryi(combi);
            afficher(combi);

        }
        public static void masteryi(int[] combi)
        {
            Random rnd = new Random();

            for (int n = 0; n < combi.Length; n++)
            {
                int nombre = rnd.Next(1, 6);
                combi[n] = nombre;
            }
        }
        public static void afficher (int [] combi)
        {
            for (int b = 0; b < 3; b++)
            {
                Console.Write(combi[b] + " ");
                
            }
        }
        
    }
}
