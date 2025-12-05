using System.Runtime.Intrinsics.Arm;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] liczby = { 88, 70, 89, 86, 87, 60, 69, 67 };


            Console.WriteLine("wypisanie liczb");
            for (int i = 0; i < liczby.Length; i++)
            {
                Console.WriteLine(liczby[i] + ", ");
            }

            Console.WriteLine("1. suma liczb w tablicy");
            int suma = 0;
            for (int i = 0; i < liczby.Length; i++)
            {
                suma += liczby[i];
            }
            Console.WriteLine("suma to: " + suma);

            Console.WriteLine("2. znajdowanie najw i najm elementu");
            int min = liczby[0];
            int max = liczby[0];
            for (int i = 0; i < liczby.Length; i++)
            {
                if (min > liczby[i])
                {
                    min = liczby[i];
                }
                if (max < liczby[i])
                {
                    max = liczby[i];
                }
            }
            Console.WriteLine("najniejsza liczba z tablicy to: " + min);
            Console.WriteLine("największa liczba z tablicy to: " + max);


            string[] imiona = { "amelyka", "krzysztofina", "aleks pstrąg", "idania", "pajotrek", "wiktorki" };

            Console.WriteLine("\n3. wypisz imiona w odwrotnej kolejnosci");
            for (int i = imiona.Length-1; i>=0; i--)
            {
                Console.Write(imiona[i] + ", ");
            }

            Console.WriteLine("\n4. liczby parzyste");

            int licznikParzyste = 0;
            int licznikNieparzyste = 0;

            foreach (int liczba in liczby)
            {
                if (liczba % 2 == 0)
                {
                    licznikParzyste++;
                }
                else
                {
                    licznikNieparzyste++;
                }
            }

            Console.WriteLine("Liczb parzystych: " + licznikParzyste);
            Console.WriteLine("Liczb nieparzystych: " + licznikNieparzyste);


            Console.WriteLine("5. Kopiowanie i modyfikacja tablicy");
            int[] liczby2 = new int[liczby.Length];

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby2[i] = liczby[i] * 2;
                Console.Write(liczby2[i] + ", ");

            }

                Console.WriteLine("\n6. Wyszukiwanie elementu popdanego przez uzytkownika");
                Console.WriteLine("Witaj, podaj liczbe ktora twoim zdaniem znajduje sie w mojej tablicy: ");
                int szukana = int.Parse(Console.ReadLine());
                bool czyZnaleziono = false;

                for (int i = 0; i < liczby.Length; i++)
                {
                    if (liczby[i] == szukana)
                    {
                        Console.WriteLine("Liczba " + szukana + " znajduje się w tablicy na indeksie " + i + ".");
                        czyZnaleziono = true;
                        break;
                    }
                } 
                if (!czyZnaleziono)
                {
                    Console.WriteLine("Liczba " + szukana + " nie została znaleziona w tablicy!");
                }


                Console.WriteLine("7. Odwracanie tablicy w miejscu (in-place)");
                int[] maleLiczby = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < maleLiczby.Length / 2; i++)
                {
                    int tymczasowa = maleLiczby[i];
                    maleLiczby[i] = maleLiczby[maleLiczby.Length - 1 - i];
                    maleLiczby[maleLiczby.Length -1 -i] = tymczasowa;
                }
                Console.WriteLine("Odwrócona: " + string.Join(", ", maleLiczby));


                Console.WriteLine("8. Praca z tablicą dwuwymiarową");
                int[,] macierz = {
                    { 11, 22, 33 },
                    { 44, 55, 66 },
                    { 77, 88, 99 }
                };
            int sumaPrzekatnej = 0;

            for (int i = 0; i < macierz.GetLength(0); i++) 
            {
                sumaPrzekatnej += macierz[i, i];
            }

            Console.WriteLine("Suma przekątnej: "+ sumaPrzekatnej);


            Console.WriteLine("9. Sortowanie"); 
            


            Console.WriteLine("10. idk");
            int[] liczbyy = { 1, 1, 1, 1, 2, 2, 3, 4, 4, 4, 5 };



            Console.WriteLine("11. tulipan");
            string[] tablicaLiter = {"o", "p", "p", "a"};

            bool czyTulipan = true;

            for (int i = 0; i < tablicaLiter.Length / 2; i++)
            {
                if (tablicaLiter[i] != tablicaLiter[tablicaLiter.Length - 1 - i])
                {
                    czyTulipan = false;
                    break;
                }
            }
            if (!czyTulipan)
            {
                Console.WriteLine("Tablica jest palindromem.");
            } else
                Console.WriteLine("Tablica nie jest palindromem.");
            }

        }
    }
    

