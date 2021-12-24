using System;

namespace MasterMind
{
    public static class Global
    {
        //Variable globale qui définit la longeur du tableau
        public static int longeur = 4;
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            int[] combiJ, clone, combi ;
            int chances,rouge,blanc,dummy;
            string chanceUser, proposition,reponse;           

            //Utilisation de la fonction qui randomise
            masterRandom(out combi);
            //Back-up du tableau
            Clonnage(combi, out clone, out reponse);

            //Nombres de chances  + Vérrication des imputs
            do
            {
                Console.WriteLine("Combien de chance voulez-vous ?");
                chanceUser = Console.ReadLine();
            } while (!int.TryParse(chanceUser, out chances));

            //Boucle princiaple 
            do
            {
                //Encodage de la proposition de l'utilisateur + Vérrication des imputs 
                do
                {
                    Console.WriteLine($"Entrez {Global.longeur} chiffres que vous avez choisit");
                    proposition = Console.ReadLine();
                } while (!int.TryParse(proposition,out dummy) || proposition.Length != Global.longeur);
               
                StringToArray(proposition, out combiJ);
                //Comptabilise les pions rouges/blancs
                pionRouge(combi, combiJ, out rouge);
                pionBlanc(combi, combiJ, out blanc);
                afficher(blanc, rouge);
                chances--;
                ClonnageInv(clone, out combi);
            } while (rouge != Global.longeur && chances > 0);

            //Résulat final 
            if (rouge == Global.longeur)
            {
                Console.WriteLine("Tu es trop fort !!! ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"t'es nul, le nombre à deviner était {reponse} ");
                Console.ReadLine();
            }

        }
       
        //Convertit les imputs en tableau
        static void StringToArray(string proposition, out int[] combiJ)
        {
            combiJ = new int[Global.longeur];

            for (int i = 0; i < combiJ.Length; i++)
            {
                combiJ[i] = int.Parse(proposition[i].ToString());
            }
        }

        //Randomizer 
        public static void masterRandom(out int[] combi)
        {
            combi = new int[Global.longeur];
            Random rnd = new Random();

            for (int n = 0; n < combi.Length; n++)
            {
                int nombre = rnd.Next(1, 6);            
                combi[n] = nombre;
            }
        }

        //Restauration du back-up
        public static void ClonnageInv(int[] clone, out int[] combi)
        {
            combi = new int[Global.longeur];
            for (int i = 0; i < clone.Length; i++)
            {
                combi[i] = clone[i];

            }
        }

        //Back-up du tableau
        public static void Clonnage(int[] combi, out int[] clone,out string reponse)
        {
            clone = new int[Global.longeur];
            reponse = "";
            for (int i = 0; i < clone.Length; i++)
            {
                clone[i] = combi[i];
                reponse = reponse + clone[i] + "";
            }      
        }

        //Comptabilise les pions rouges
        public static void pionRouge(int[] combi, int[] combiJ, out int rouge)
        {
             rouge = 0;
           
            
            for (int i = 0; i < combi.Length; i++)
            {
    
                if (combiJ[i] == combi[i])
                {
                    rouge = rouge + 1;
                    combiJ[i] = -1;
                    combi[i] = -2;
                }
            }
       

        }

        //Comptabilise les pions blancs
        public static void pionBlanc(int[] combi, int[] combiJ,out int blanc)
        {
            blanc = 0;
            for (int i = 0; i < combi.Length; i++)
            {
                for (int j = 0; j <combi.Length; j++)
                {
                    if (combi[i] == combiJ[j])
                    {
                        blanc = blanc + 1;
                        combiJ[j] = -1;
                    }
                }
               
            }
        }

        //Affichage intérmédiaire
        public static void afficher (int blanc, int rouge)
        {
            Console.WriteLine($"Voici le nombre de pions blanc {blanc}");
            Console.WriteLine($"Voici le nombre de pions rouge {rouge}");          
            
        }
       

    }
}
