using System;

namespace beep_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] morseovka = new string[1,7];


                for (int i = 0; i < morseovka.GetLength(0); i++)
                {
                    for (int j = 0; j < morseovka.GetLength(1); j++)
                    {
                        Console.Write($"{ morseovka[i, j],+10}");
                    }
                    Console.WriteLine();
                }
                Console.Write(@"===============================
 1 >> konverze z abecedy do morseovky
 2>> vypni/zapni Beep
 3>>
 K >> ======konec
=========================
Tvůj výběr: ");
                string choice = Console.ReadLine();

                if (choice == "k" || choice == "K")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
