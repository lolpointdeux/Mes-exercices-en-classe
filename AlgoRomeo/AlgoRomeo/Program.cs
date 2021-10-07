using System;

namespace AlgoRomeo
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string awnser;
           
            Console.WriteLine("Quel age avez-vous ?");
            age = int.Parse((Console.ReadLine()));

            Class1 class1 = new Class1();

            class1.calcul(age, out awnser);

            Console.WriteLine(awnser);
            Console.ReadLine();



        }
    }
}
