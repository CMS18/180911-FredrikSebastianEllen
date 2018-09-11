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

            string förstaMeddelande = "En liten rolig filur som hette " + name + " som var " + age + " år gammal gick ut en vacker dag...";

            Console.WriteLine(förstaMeddelande);






            Console.ReadLine();
        }
    }
}
