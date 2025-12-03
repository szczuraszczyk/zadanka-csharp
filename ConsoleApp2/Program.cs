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

            Console.WriteLine("Liczb parzystych: " + {licznikParzyste});
            Console.WriteLine("Liczb nieparzystych: " + {licznikNieparzyste});


            Console.WriteLine("5. Kopiowanie i modyfikacja tablicy");
            int[] liczby2 = new int[liczby.Length];

            for (int i = 0; i < liczby.Length; i++)
            {
                liczby2[i] = liczby[i] * 2;
                Console.Write(liczby2[i] + ", ");
                break;

            }

                Console.WriteLine("\n6. Wyszukiwanie elementu popdanego przez uzytkownika");
                Console.WriteLine("Witaj, podaj liczbe ktora twoim zdaniem znajduje sie w mojej tablicy: ");
                int liczbaUzytkownika = int.Parse(Console.ReadLine());
                bool czyZnaleziono = false;

                for (int i = 0; i < liczby.Length; i++)
                {
                    if (liczby[i] == szukana)
                    {
                        Console.WriteLine("Liczba " + {szukana} + " znajduje się w tablicy na indeksie "+{i}+".");
                        czyZnaleziono = true;
                        break;
                    } else {
                        Console.WriteLine("Liczba " + {szukana} " nie została znaleziona w tablicy.");

                    }
                }


                Console.WriteLine("7. Odwracanie tablicy w miejscu (in-place)");
                int[] maleLiczby = { 1, 2, 3, 4, 5 };
                int[] noweMaleLiczby = new int[5];

                int indeksNowych = 0; 

                for (int i = maleLiczby.Length - 1; i >= 0; i--)
                {
                    noweMaleLiczby[indeksNowej] = maleLiczby[i];
                    indeksNowej++; 
                }

                Console.WriteLine("Odwrócona: " + string.Join(", ", noweMaleLiczby));


                Console.WriteLine("8. Praca z tablicą dwuwymiarową");
                int[,] macierz = {
                    { 1, 2, 3 },
                    { 4, 5, 6 },
                    { 7, 8, 9 }
                };

            int suma = macierz[0,0] + macierz[1,1] + macierz[2,2];

            Console.WriteLine("Suma przekątnej: "+ {suma});


            Console.WriteLine("9. Sortowanie");
            Array.Sort(liczby); 
            Console.WriteLine("Posortowane: " + string.Join(", ", liczby));
        }
    }
    }

