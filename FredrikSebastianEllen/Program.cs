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

            // Lägg till variablerna i WriteLine.


            Console.WriteLine($"{förstaMeddelande} {användarSvar}");

            Console.ReadLine();
        }
    }
}
