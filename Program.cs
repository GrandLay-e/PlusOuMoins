using System;

namespace PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue au jeu de devinette !");
            Random random = new Random();
            int hazard = random.Next(1,1000);
            int lastPos = 1000;
            int lastNeg = 1;
            int cherche = lastNeg;

            int coups = 0;
            do{
                if(cherche < hazard)
                {
                    Console.WriteLine("+");
                    lastNeg = cherche;
                    cherche = random.Next(lastNeg, lastPos);
                }
                else if(cherche > hazard)
                {
                    Console.WriteLine("-");
                    lastPos = cherche;
                    cherche = random.Next(lastNeg, lastPos);
                }
                coups ++;
                Console.WriteLine($"[ {lastNeg} \t| {cherche} <--> {hazard} \t| {lastPos} ]");
            }while(cherche != hazard);
            Console.WriteLine("\n\tGagné ! "+coups+" coups ");
        }
    }
}