using System;


namespace PracticaFormativa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperHeroe hero1 = new SuperHeroe("Batman", 90, 70, 0);
            SuperHeroe hero2 = new SuperHeroe("S" , 95, 60, 70);

            Console.WriteLine(hero1.competir(hero2)); 
            Console.WriteLine(hero2.competir(hero1));
        }
    }
}
