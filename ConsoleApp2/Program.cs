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
            foreach (int liczba in liczby)
            {
                bool parzysta = liczba % 2 == 0;
                if (parzysta == true)
                {
                    Console.Write(liczba + ", ");
                }
            }

                //Console.WriteLine("Kopiowanie i modyfikacja tablicy");
                //int[] A = { 1, 2, 3, 4 };
                //int[] B = { };
                //for (int i = 0; i<A.Length; i++)
                //{
                //    B = B + (A[i] * A[i]);
                //}

                Console.WriteLine("\n6. Wyszukiwanie elementu popdanego przez uzytkownika");
                Console.WriteLine("Witaj, podaj liczbe ktora twoim zdaniem znajduje sie w mojej tablicy: ");
                int liczbaUzytkownika = int.Parse(Console.ReadLine());
                bool czyZnaleziono = false;
                int o = 0;
                string odp = "Liczba " + liczbaUzytkownika + " nie została znaleziona w tablicy.";
                while (o < liczby[o])
                {
                    o++;
                    if (liczbaUzytkownika == liczby[o])
                    {
                        czyZnaleziono = true;
                        odp = "Liczba " + liczbaUzytkownika + " znajduje się w tablicy na indeksie " + o;
                        break;
                    }
                    else
                    {
                    continue;
                    }

                }
                Console.WriteLine(odp);


        }
        }
    }

