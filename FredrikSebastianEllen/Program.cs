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

            Console.Write("Beskriv vädret: ");
            var weather = Console.ReadLine();

            string förstaMeddelande = "En liten rolig filur som hette " + name + " som var " + age + " år gammal gick ut en " + weather + " dag för att...";

            Console.WriteLine(förstaMeddelande);
            Console.Write("Vad ville " + name + " göra sen?");
            string användarSvar = Console.ReadLine();

            Console.WriteLine(name + " ville " + användarSvar + " och gick sedan för att dansa tango iklädd en björndräkt.");

            string andraMeddelande = $"Just nu är {name} lite trött eftersom {name} jobbade hela valnatten...";
            Console.WriteLine(andraMeddelande);
            Console.WriteLine("Efter att han tog en snabb tupplur så blev " + name + " uttråkad.. ");
            Console.Write($"{name} ville äta någonting...");
            string tredjeMeddelande = Console.ReadLine();

            Console.WriteLine($"eftersom att han är { age } år gammal, så var han tvungen att äta {tredjeMeddelande}... mm vad gott! sa {name}");









            Console.ReadLine();
        }
    }
}
