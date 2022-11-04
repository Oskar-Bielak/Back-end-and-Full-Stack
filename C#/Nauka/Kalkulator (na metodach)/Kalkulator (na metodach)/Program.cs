using System;

namespace Kalkulator__na_metodach_
{
    class Program
    {
        //Metody dzielimy na dwa typy zwracajace wartosc int oraz ktore nie musza zwracac nic void
        // Metoda ma sie zajmowac jedna wybrana rzecza nie pare na raz
        
        static int Wieksza(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int Dziel(int a, int b)
        {
            int c;
            c= a / b;
            return c;
        }

        static int Mnoz(int a, int b)
        {
            int c;
            c = a * b;
            return c;
        }

        static int Odemij(int a, int b)
        {
            int c;
            c = a - b;
            return c;
        }

        static int Dodaj(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator");
            Console.WriteLine("Wybeirz opcje: ");
            Console.WriteLine("1.Dodawanie ");
            Console.WriteLine("2.Odejmowanie ");
            Console.WriteLine("3.Mnożenie ");
            Console.WriteLine("4.Dzielenie "); 
            Console.WriteLine("5.Wieksza Liczba ");
            string setMenu = Console.ReadLine();
            int menu = int.Parse(setMenu);
            Console.Clear();
            Console.WriteLine("Wprowadz Pierwsza Liczbe: ");
            string number1 = Console.ReadLine();
            int SetNumber1 = int.Parse(number1);
            Console.WriteLine("Wprowadz Pierwsza Liczbe: ");
            string number2 = Console.ReadLine();
            int SetNumber2 = int.Parse(number2);
            

            switch (menu)
            {
                case 1:
                    int dodaj = Dodaj(SetNumber1, SetNumber2);
                    Console.WriteLine(dodaj);
                    break;
                case 2:
                    int odejmij = Odemij(SetNumber1, SetNumber2);
                    Console.WriteLine(odejmij);
                    break;
                case 3:
                    int mnoz = Mnoz(SetNumber1, SetNumber2);
                    Console.WriteLine(mnoz);
                    break;
                case 4:
                    int dziel = Dziel(SetNumber1, SetNumber2);
                    Console.WriteLine(dziel);
                    break;
                case 5:
                    int wieksza = Wieksza(SetNumber1,SetNumber2);
                    Console.WriteLine(wieksza);
                    break;

            }
            
        }
    }
}
