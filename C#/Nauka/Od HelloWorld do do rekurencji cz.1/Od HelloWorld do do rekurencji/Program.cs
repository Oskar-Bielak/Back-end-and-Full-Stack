using System; //Biblioteki - Biblioteki mozna odejmowac w celu zmniejszenia pliku kompilacyjnego - Optymalizacja programu.

namespace Od_HelloWorld_do_do_rekurencji //Przestrzen nazw Kontener
{
    class Program //Klasa
    {
        static void Main(string[] args) //Metoda/Funkcja Główna
                                        //Funkcja -Jezyk nie Obiektowy.
                                        //Metoda - Jezyk Obiektowy.
        {
            ////Deklaracja zmiennej


            //var liczba = 1; // Inteligentna stała. Zmienna ktora moze byc kazdym typem zmiennej(INT(całkowity), INT32(całkowity alternatywny), BYTE, STRING(łancuch=Nazwa, Kod ASCII), BOOL(true/false), double(zmienno-przeinkowy))
            //const float PI = 3.14F; //const stała, musi byc zadeklarowana w momencie tworzenia. niezmienna w całości prokjektu.  

            ////Deklaracja zmiennej a przypisanie.
            //int opcja1; //Definicja zmiennej
            //opcja1 = 12; // Przypisanie wartośći

            //// Dane całkowite
            //int max = int.MaxValue; //Typ całkowity o nazwie max = maksymalnej całkowitej warośći  
            //byte maxbyte = byte.MaxValue; //Zmienna byte ktora moze przechowac od 0 do 255 
            //short maxshort = short.MaxValue;
            //long maxlong = long.MaxValue;
            //sbyte minbyte = sbyte.MinValue; //Zmienna byte ktora moze przechowac od -128 do 127 \

            ////Dane zmienno-przecinkowe 
            //float maxfloat = float.MaxValue;
            //double maxdouble = double.MaxValue;
            //decimal maxdecimal = decimal.MaxValue;

            ////Dane tekstowe 
            //string hello = "Hello"; //Typ Łancuchowy  o nazwie hello = przekazanie 
            //char znak = 'E'; //Zmienna przyjmujaca jedna wartość, tylko jedna wartość !!!
            //bool truebool = true; // Zmienna bool wartość true/false, mozna dac operatory np. 5>2 działania matematyczne dajace true/false.
            //bool piecdwa = 5 > 2 && 5>3; // && operator i, bool dajacy winik działania 
            //bool wynik = piecdwa; // przypisanie do bool wyniku wyżej


            ////Operatory arytmetyczne i logiczne

            //int z;
            //int p;
            //int d;
            //int x = 2; //Operatory arytmetyczne
            //int y = 3;//Operatory arytmetyczne

            //z = x + y; // y+=x to samo, w zmiennej bedzie liczbie 'x' bedzie wynik i+=1 inkrementacja to samo co i++.
            //p = x - y;
            //d = x % y; // % - reszta z dzielenia 

            //bool a = 2 >= 1;  //Operatory logiczne 
            //bool b = 2 == 2;  //Operatory logiczne czy liczby sa rowne
            //bool c = 2 != 2;  //Operatory logiczne czy liczby sa różne
            //bool e = !(2 == 2);//Operatory logiczne negacja prawdy, działa hierarchia matematyczna.
            //bool f = 1 == 1 && 1!=1; // Pierwszy warunek true (&& - znaczy I, AND), druga wartość false.
            //bool g = 1 == 1 || 1 != 1; // Pierwszy warunek true (|| - znaczy LUB, OR), druga wartość false.
            //bool h = true || true && false;

            ////Instrukcja IF
            //int wartosc = 1;
            //bool drugi = wartosc > 0;

            //// Wyświetlanie zmiennych
            //Console.WriteLine("Wyświetlanie zmiennych");
            //Console.WriteLine(maxdouble); //Wyświetlenie maksymalnej wiekosci long
            //Console.WriteLine(maxlong); //Wyświetlenie maksymalnej wiekosci long
            //Console.WriteLine(maxshort); //Wyświetlenie maksymalnej wiekosci short
            //Console.WriteLine(maxbyte); //Wyświetlenie maksymalnej wiekosci byte
            //Console.WriteLine(max); // Wyswietlenie maksymalnej liczby całkowitej.
            //Console.WriteLine(hello);
            //Console.WriteLine(maxfloat);
            //Console.WriteLine(liczba);
            //Console.WriteLine(minbyte);
            //Console.WriteLine(maxdecimal);
            //Console.WriteLine(PI);
            //Console.WriteLine(truebool);
            //Console.WriteLine(wynik);
            //Console.WriteLine(opcja1);
            //Console.WriteLine(z);
            //Console.WriteLine("Hello World!"); //Metoda Output ktory dostaje strumien danych = Hello World.
            //// Wyświetlanie Operatory arytmetyczne i logiczne
            //Console.WriteLine("Wyświetlanie Operatory arytmetyczne i logiczne");
            //Console.Write("Wynik dodawania: ");
            //Console.WriteLine(z);
            //Console.Write("Wynik odejmowanie: ");
            //Console.WriteLine(p);
            //Console.Write("Wynik reszta z dzielenia: ");
            //Console.WriteLine(d);
            //Console.Write("Wynik logiczny działania a: ");
            //Console.WriteLine(a);
            //Console.Write("Wynik logiczny działania b: ");
            //Console.WriteLine(b);
            //Console.Write("Wynik logiczny działania c: ");
            //Console.WriteLine(c);
            //Console.Write("Wynik logiczny działania e: ");
            //Console.WriteLine(e);
            //Console.Write("Wynik logiczny działania f: ");
            //Console.WriteLine(f); 
            //Console.Write("Wynik logiczny działania g: ");
            //Console.WriteLine(g);
            //Console.Write("Wynik logiczny działania h: ");
            //Console.WriteLine(h);
            //Console.WriteLine(Math.Pow(2, 3)); //Potegowanie 
            //Console.WriteLine(Math.Sqrt(3));  //Pierwiastek
            //Console.WriteLine(Math.Abs(-3)); //Wartosc bezwzgledna
            ////Instrukcja IF

            //if(drugi)
            //{
            //    Console.WriteLine("Wartosc jest wieksza od 0"); //Instrukcja
            //}
            //else
            //{
            //    Console.WriteLine("Wartosc jest mniejsze 0");
            //}
            //// To samo co u góry ale inaczej zapisane
            //if (wartosc > 0)
            //{
            //    Console.WriteLine("Wartosc jest wieksza od 0"); //Instrukcja
            //}
            //if (wartosc < 0)
            //{
            //    Console.WriteLine("Wartosc jest mniejsze 0");
            //}
            //// Kolejne wersja
            //if (wartosc > 0)
            //{
            //    Console.WriteLine("Wartosc jest wieksza od 0"); //Instrukcja
            //}
            //else if (wartosc > 5)
            //{
            //    Console.WriteLine("Wartosc jest wieksza od 5"); // Nie jest brany pod uwage jesli pierwzszy if zostanie spełniony
            //}
            //else if (wartosc == 0)
            //{
            //    Console.WriteLine("Wartosc jest równa 0");
            //}
            //else
            //{
            //    Console.WriteLine("Wartosc jest mniejsze 0");
            //}

            ////Kolejny o IF
            //if (wartosc > 5)
            //{
            //    Console.WriteLine("Wartosc jest wieksza od 5"); //Instrukcja
            //}

            //// Pętla | FOR | WHILE | DOWHILE

            //Console.WriteLine("Pętla | FOR | WHILE | DOWHILE");
            ////While
            //int xd = 0;

            //while (xd < 5) //dopoki warunek jest true jest wykonywany.
            //{

            //    Console.Write("Numer petli: "); 
            //    Console.WriteLine(xd);
            //    xd++;
            //}
            ////FOR
            //for(int xd_petla = 0; xd_petla <5 ;xd_petla++ ) // mozna zrobic defincije przed petla :D 
            //{
            //    Console.Write("Numer petli: ");
            //    Console.WriteLine(xd_petla);
            //}
            ////DOWHILE
            //do
            //{
            //    Console.Write("Petla DOWHILE: ");
            //}
            //while (false);

            ////Rzucanie zmiennych
            //int i = int.MaxValue;
            //short s = short.MaxValue;

            //i = s;
            //s = (short)i;
            //Console.WriteLine(i);
            ////Wczytywanie danych z konsoli



            //if(Console.ReadKey().Key == ConsoleKey.D1)
            //{
            //    Console.WriteLine("Prawda");
            //}

            //string xds = Console.ReadLine(); //Wczytywanie danych do konsoli
            //Console.WriteLine(xds);
            ////Konwersja Typów (STRING > INT, INT > STRING) 
            //Console.WriteLine("Konwersja Typów");

            //int gf =int.Parse(xds) + 2; // zmianna typu wprowadzonego z konsoli z STRING NA INT
            //Console.WriteLine(gf);
            //xds = gf.ToString(); //zmianna typu wprowadzonego do konsoli z INT na STRING
            //Console.WriteLine(xds);

            //Łączenie tekstu & formatowanie "WRITELINE"
            //string s1 = "Witaj";
            //string s2 = " Świecie";
            //string s3 = s1 + s2;
            //Console.WriteLine(s3);
            //Console.WriteLine(s1+s2+"!!!");
            //Console.WriteLine("{0}{1}", s1,s2);

            //Modyfikacja wyglądu konsoli
            string s1 = "Witaj";
            string s2 = " Świecie";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0}{1}", s1, s2);
            Console.Clear();
            Console.ReadKey(); //Metoda Input - przyjmuje dane od nas.
        }
    }
}
