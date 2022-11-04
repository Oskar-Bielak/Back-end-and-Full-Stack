using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_Typu_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tytuł gry");
            string subtitles = Console.ReadLine();

            
            
            Console.WriteLine(subtitles);
            Console.WriteLine();
            Console.WriteLine("1. Nowa gra");
            Console.WriteLine("2. Wczytaj gre");
            Console.WriteLine("3. Wyjście");
            string set = Console.ReadLine();
            if(set == "1")
            {
                Console.Clear();
                Console.WriteLine("Wybierz postac: ");
                string nameChampion = Console.ReadLine();

            }
            else if (set == "2")
            {

            }
            else
            {
             
            }
            Console.WriteLine("Wybrano opcje: " + set);
            ;
        }
    }
}
