using System;

namespace Liczby_porownywanie_ktora_wieksza
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz pierwsza liczbe");
            string number1 = Console.ReadLine();
            Console.WriteLine("Wpisz druga liczbe");
            // Ważne w C# nie pobierz bezposrednio zmiennej Intger tylko masz Stringa ktorego przerabiasz przez parse na Int, W druga strone jest to samo instrukcja ToString();
            // Co dziwne wypisywac mozesz liczby czy inne zmienne na ekranie ale przyjmowac do programu mozesz je tylko przez string.
            string number2 = Console.ReadLine();
            int setNumer1 = int.Parse(number1);
            int setNumber2 = int.Parse(number2);
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("1. Dodaj: ");
            Console.WriteLine("2. Odejmij: ");
            Console.WriteLine("3. Podziel: ");
            Console.WriteLine("4. Pomnoż: ");
            Console.WriteLine("5. Wyznacz wieksza: ");
            Console.WriteLine("Wybierz Opcje: ");
            string menu = Console.ReadLine();
            int setMenu = int.Parse(menu);
            
            switch (setMenu){
                case 1:
                    int dodaj = setNumer1 + setNumber2;
                   Console.WriteLine(dodaj);
                    break;
                case 2:
                    int odejmij = setNumer1 - setNumber2 ;
                    Console.WriteLine(odejmij);
                    break;
                case 3:
                    int podziel = setNumber2 / setNumer1;
                    Console.WriteLine(podziel);
                    break;
                case 4:
                    int pomnoz = setNumber2 * setNumer1;
                    Console.WriteLine(pomnoz);
                    break;
                case 5:
                    if (setNumer1 > setNumber2)
                    {
                        Console.WriteLine("Wieksza Liczba jest " + setNumer1);
                    }
                    else
                    {
                        Console.WriteLine("Wieksza liczba jest " + setNumber2);
                    }
                    break;
            }

            
        }
    }
}
