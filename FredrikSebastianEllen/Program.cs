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
            string förstaMeddelande = "En liten rolig filur som hette ";

            Console.WriteLine(förstaMeddelande);

            Console.Write("Fortsätt storyn...");
            string användarSvar = Console.ReadLine();
                    
            // Fortsätt historien här under

            string andraMeddelande = "Fredrik. Han var C#-lärare och älskade kaffe. Det han helst gör på sin fritid ";

            Console.WriteLine(andraMeddelande);

            string tredjeMeddelande = "är att läsa och köra bil. " +
                                        "Just nu är han lite trött eftersom han jobbade hela valnatten...";

            Console.WriteLine(tredjeMeddelande);

            // Lägg till variablerna i WriteLine.




            Console.ReadLine();
        }
    }
}
