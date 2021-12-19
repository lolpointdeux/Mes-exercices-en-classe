using System;

namespace MasterMind
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] combiJ ;
            int[] combi ;
            string proposition;

            Console.WriteLine($"Entrez les couleur que vous avez choisit");
            proposition = Console.ReadLine();

            StringToArray(proposition, out combiJ);
            masterRandom(out combi);
            pionRouge(combi, combiJ);
            afficher(combi);
            

        }
        static void StringToArray(string proposition, out int[] combiJ)
        {
            combiJ = new int[4];

            for (int i = 0; i <= 3; i++)
            {
                combiJ[i] = int.Parse(proposition[i].ToString());
            }
        }
        public static void masterRandom(out int[] combi)
        {
            combi = new int[4];
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
                    combiJ[i] = -1;
                    combi[i] = -2;
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
                        combiJ[i] = -1;
                    }
                }
               
            }
        }
        public static void afficher (int [] combi)
        {
            for (int i = 0; i < combi.Length; i++)
            {
                Console.Write(combi[i] + " ");
                
            }
        }
       

    }
}
