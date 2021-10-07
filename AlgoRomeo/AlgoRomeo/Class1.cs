using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoRomeo
{
    class Class1
    {
        public void calcul(int age , out string awnser)
        {
            if (age > 14 || age < 6 )
            {
                awnser = "Vous n'avez pas l'age requis";
            }
            else if (age >= 12)
            {
                awnser = "Vous etes cadet ";
            }
            else if (age >= 10)
            {
                awnser = "Vous etes un Minime";
            }
            else if (age >= 8)
            {
                awnser = "Vous êtes un pupil";
            } else
                awnser = "Vous êtes un Poussin";
        }
      

       
    }
}
