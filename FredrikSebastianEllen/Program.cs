using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredrikSebastianEllen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            var name = Console.ReadLine();

            Console.Write("Hur gammal är du? ");
            var age = int.Parse(Console.ReadLine());

            Console.Write("Beskriv vädret ");
            var weather = Console.ReadLine();

            string förstaMeddelande = "En liten rolig filur som hette " + name + " som var " + age + " år gammal gick ut en " + weather + " dag för att...";

            Console.WriteLine(förstaMeddelande);
            Console.Write("Fortsätt storyn...");
            string användarSvar = Console.ReadLine();
                    
            // Fortsätt historien här under

            


            string andraMeddelande = "Just nu är hen lite trött eftersom han jobbade hela valnatten...";
            Console.WriteLine(andraMeddelande);
            Console.Write("Fortsätt storyn...");
            string tredjeMeddelande = Console.ReadLine();

            // Lägg till variablerna i WriteLine.




            Console.ReadLine();
        }
    }
}
