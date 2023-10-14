using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace laboratory_work
{
    internal class Program
    {
        static (int, int) Counts_vowels_and_consonants(char[] Letters_array)
        {
            char[] vowels_array = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я' };
            int number_of_vowels = 0;
            int number_of_consonants = 0;
            foreach (char letter in Letters_array)
            {
                if ((int)letter >= 1040 && (int)letter <= 1103)
                {
                    if (vowels_array.Contains(letter))
                    {
                        number_of_vowels++;
                    }
                    else
                    {
                        number_of_consonants++;
                    }
                }
            }

            return (number_of_vowels, number_of_consonants);
        }
        static void Main(string[] args)
        {
            // Упражнение 6.1
            Console.WriteLine("Упражнение 6.1");
            Console.WriteLine("В этом упражнении программа читает файл и считает количество гласных и согласных букв");
            char[] readText = File.ReadAllText("Additional files/Text.txt").ToLower().ToCharArray();
            Console.WriteLine($"Гласных букв: {Counts_vowels_and_consonants(readText).Item1}\nСогласных букв: {Counts_vowels_and_consonants(readText).Item2}");
            Console.ReadKey();
            // Упражнение 6.2

        }
    }
}