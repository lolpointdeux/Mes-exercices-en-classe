using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combiJ = new int[4];
            int[] combi = new int[4];

            for (int c = 0; c < 4; c++)
            {
                Console.WriteLine($"Entrez la {c} couleur que vous avez choisit");
                combiJ[c] = int.Parse(Console.ReadLine());
            }
                   
            masterRandom(combi);
            pionRouge(combi, combiJ);
            afficher(combi);
            

        }
        public static void masterRandom(int[] combi)
        {
            Random rnd = new Random();

            for (int n = 0; n < combi.Length; n++)
            {
                int nombre = rnd.Next(1, 6);            
                combi[n] = nombre;

            }
        }
        public static void pionRouge(int [] combi, int[] combiJ)
        {
            int rouge = 0;
            for (int i = 0; i < combi.Length; i++)
            {
                
                if (combi[i] == combiJ[i])
                {
                    rouge = rouge + 1;
                }
            }
       

        }
        public static void pionBlanc(int[] combi, int[] combiJ)
        {
            int blanc = 0;
            for (int i = 0; i < combi.Length; i++)
            {
                for (int j = 0; j <combi.Length; j++)
                {
                    if (combi[i] == combiJ[j])
                    {
                        blanc = blanc + 1;
                    }
                }
               
            }
        }
        public static void afficher (int [] combi)
        {
            for (int b = 0; b < combi.Length; b++)
            {
                Console.Write(combi[b] + " ");
                
            }
        }
        
    }
}
