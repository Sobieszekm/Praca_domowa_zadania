using System;
using System.Collections.Generic; // Kolekcje użyte do zadania 3 

namespace Praca_domowa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 2

            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            // Zadanie 3

            int result = 5 + 9;
            Console.WriteLine(result);

            // Operatory
            // Zadanie 1

            int number = 10;
            float money = 15.5f;
            string text = "Hello World";
            bool isLogged = true;
            char myChar = 'A';
            decimal price = 20.99m;

            Console.WriteLine("Number: " + number);
            Console.WriteLine("Money: " + money);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("Is logged: " + isLogged);
            Console.WriteLine("Character: " + myChar);
            Console.WriteLine("Price: " + price);

            // Zadanie 2

            string myAge = "Age: ";
            int wifeAge = 18;
            string resultx = myAge + wifeAge.ToString();

            Console.WriteLine(resultx);

            // Wniosek - należy uważać na powtarzające się zmienne w tym samym projekcie
            // Wniosek - wymagana jest zmiana  int na string

            // Zadanie 3

            bool isTrue = true;
            bool isFalse = false;
            bool isReallyTrue = true;

            bool and = isTrue && isFalse;
            bool or = isTrue || isReallyTrue;
            bool negative = !isFalse;

            Console.WriteLine("And: " + and);
            Console.WriteLine("Or: " + or);
            Console.WriteLine("Negative: " + negative);

            // Zadanie 4

            int a = 5;
            int b = 12;

            int add = a + b;
            int sub = a - b;
            int div = a / b;
            int mul = a * b;
            int mod = a % b;

            Console.WriteLine("Add: " + add);
            Console.WriteLine("Sub: " + sub);
            Console.WriteLine("Div: " + div);
            Console.WriteLine("Mul: " + mul);
            Console.WriteLine("Mod: " + mod);

            // Zadanie 5

            string aa = "Ala ";
            string bb = "ma ";
            string cc = "kota";

            string resultt = aa + bb + cc;
            Console.WriteLine(resultt);

            // Wniosek - należy uważać na powtarzające się zmienne w tym samym projekcie
            // Wniosek - w przypadku zmiennych typu string można je łączyć ze sobą

            // Zadanie 1

            int n1 = 10;
            int n2 = 20;

            if (n1 > n2)
            {
                Console.WriteLine("n1 jest większe od n2");
            }
            else if (n2 > n1)
            {
                Console.WriteLine("n2 jest większe od n1");
            }
            else
            {
                Console.WriteLine("n1 jest równe n2");
            }

            // Zadanie 2

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("C#");
            }

            int licznik = 0;

            while (licznik<10)
            {
                Console.WriteLine("C#");
                licznik++;
            }

            // Zadanie 3

            int n = 10;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i.ToString()+" - Parzysta");
                }
                else
                {
                    Console.WriteLine(i.ToString() + " - Nieparzysta");
                }
            }

            // Zadanie 4*

            n = 5;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            // Zadanie 5*

            int exam = 57;
            if (exam < 0 || exam > 100)
            {
                Console.WriteLine("Wartość poza zakresem.\n");
            }
            else if (exam >= 0 && exam <= 39)
            {
                Console.Write("Ocena Niedostateczna\n");
            }
            else if (exam >= 40 && exam <= 54)
            {
                Console.Write("Ocena Dopuszczająca\n");
            }
            else if (exam >= 55 && exam <= 69)
            {
                Console.Write("Ocena Dostateczna\n");
            }
            else if (exam >= 70 && exam <= 84)
            {
                Console.Write("Ocena Dobra\n");
            }
            else if (exam >= 85 && exam <= 98)
            {
                Console.Write("Ocena Bardzo Dobra\n");
            }
            else if (exam >= 99 && exam <= 100)
            {
                Console.Write("Ocena Celująca\n");
            }
            

            // Zadanie 1

            string[] colors = new string[4] {"niebieski", "czerwony", "zielony", "czarny"};

            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);

            // Zadanie 2

            int[] tab = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Liczba: " + tab[i]);
            }

            foreach (int i in tab)
            {
                Console.WriteLine("Liczba: " + i);
            }

            licznik = 0;

            while (licznik<10)
            {
                Console.WriteLine("Liczba: " + tab[licznik]);
                licznik++;
            }

            // Zadanie 3

            List<string> fruits = new List<string> { "Arbuz", "Banan", "Truskawka", "Mango" };
            fruits.RemoveAt(0);
            fruits.RemoveAt(fruits.Count - 1);

            Console.WriteLine(string.Join(", ", fruits));
        }

    }
    }
