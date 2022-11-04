using System;

namespace Gra__na_metodach_
{
    class Program
    {
        private static string nameChampion;
        private static int health;
        private static int maxHealth;

        static void AddChampion()
        {
            Console.Clear();
            Console.WriteLine("Podaj Imię Bohatera: ");
            nameChampion = Console.ReadLine();
        }

        static void Menu()
        {
            Console.WriteLine("1. Nowa Gra ");
            Console.WriteLine("2. Wczytaj Gre ");
            Console.WriteLine("3. Wyjscie");
            string menu = Console.ReadLine();
            int SubMenu = int.Parse(menu);
            switch (SubMenu)
            {
                case 1:
                    AddChampion();
                    break;
                case 2:

                    break;
                case 3:
                    Console.Clear();
                    break;
            }
            MenuGames();
        }
        static void MenuGames()
        {
            Console.WriteLine("1.Idz na wyprawe");
            Console.WriteLine("2.Odpocznij");
            Console.WriteLine("3.Ekwipunek");
            Console.WriteLine("4.Sklep");
            Console.WriteLine("5.Koniec");
        }
        static void IdzNaWyprawe()
        {
            Console.Clear();
            Console.WriteLine("Wyruszyłeś na Wyprawe");
            bool wynikWalki = Walka();
            if (wynikWalki)
            {
                BonusyZaZwyciestwo();
            }
            else
            {
                Przegrana();
            }
        }
        static void BonusyZaZwyciestwo()
        {

        }
        static void Przegrana()
        {
            health = 1;
        }

        // Argument bool zwraca tylko dwa typy zmiennych true lub false
        static bool Walka()
        {
            if (health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Witam W wiedzminskikm Uniwersum:");
            Menu();

        }
    }
}
