using System;

namespace Table5
{
    class Program
    {
        static void Main(string[] args)
        {
            int incr = 0;
            string chaine = "";

            do
            {
                chaine =  chaine + (incr * 5) + " " ;
                incr++;
               
            } while (incr <= 100);

            Console.WriteLine(chaine);
            Console.ReadLine();
            
        }
        

    }
}
