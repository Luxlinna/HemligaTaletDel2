using System;

namespace HemligaTaletDel2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Random randomerare = new Random();

            int slump_tal = randomerare.Next(1,101);

            Console.Write("\n Skriva in ditt gissa talet: ");
            int gissa_tal = Convert.ToInt32(Console.ReadLine());

            if (gissa_tal < 1 || gissa_tal > 100)
            {
                Console.WriteLine("\n Ditt gissa talet är utanför räckvidd !!! ");
            } 
            else if (gissa_tal == slump_tal)
            {
                Console.WriteLine ("\n Du vinner !!! Det hemliga talet är : " + slump_tal);
            } 
            else
            {
                Console.WriteLine("\n Du förlorade !!! Det hemliga talet är : " + slump_tal);
            }

            // Det för visa resultat untan 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n \tResultat !!! \n \tDet hemliga talet är : " + slump_tal + " \n \tMedan ditt gissa talet är: " + gissa_tal);
            Console.Write("\nSkriva valfri tangent för att fortsätta ... ");
            Console.ReadKey();

        }
    }
}