﻿// See https://aka.ms/new-console-template for more information
using System;


namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 3;
            // int c = 2;

            // * IF STATEMENT
            //   ============

            // if (a + b > 10)
            // {
            //     Console.WriteLine("The answer is greater than 10.");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is less than 10.");
            // }

            // if ((a + b + c > 10) && (a == b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("And the first number is equal to the second.");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("Or the first number is not equal to the second");
            // }

            // if ((a + b + c > 10) || (a == b))
            // {
            //     Console.WriteLine("The answer is greater than 10");
            //     Console.WriteLine("Or the first number is equal to the second");
            // }
            // else
            // {
            //     Console.WriteLine("The answer is not greater than 10");
            //     Console.WriteLine("And the first number is not equal to the second");
            // }

            // * LOOPS
            // =======

            // ? WHILE LOOP
            // ============

            // int counter = 0;
            // while (counter < 10)
            // {
            //     Console.WriteLine(counter);
            //     counter++;
            // }

            // ? DO WHILE LOOP
            // ===============
            // do
            // {
            //     Console.WriteLine(counter);
            //     counter++;
            // } while (counter < 10);


            // ? FOR LOOP
            // ==========
            // for (int index = 1; index <= 10; index++)
            // {
            //     Console.WriteLine($"Hello World, {index}");
            // }

            // Nested If Statement and Loops
            // =============================
            // int sum = 0;
            // for (int i = 1; i <= 10; i++)
            // {
            //     if (i % 3 == 0)
            //     {
            //         sum = sum + i;
            //     }
            // }
            // Console.WriteLine($"Total Sum is : {sum}");

            // Nested Loops
            // ============
            // for (int row = 1; row < 11; row++)
            // {
            //     for (char column = 'a'; column < 'k'; column++)
            //     {
            //         Console.WriteLine($"The cell is ({row}, {column})");
            //     }
            // }

            // ? FOREACH LOOP
            // ==============
            var names = new List<string> {
                "name",
                "Ahmed"
            };
            // foreach (string name in names)
            // {
            //     Console.WriteLine(name.ToUpper());
            // }

            // for (int i = 0; i < names.Count; i++)
            // {
            //     Console.WriteLine($"{names[i].ToLower()} ======");
            // }

            // ARRAY METHODS
            // =============
            // names.Add("Maria");
            // names.Add("Bill");
            // names.Remove("Ahmed");

            // foreach (string name in names)
            // {
            //     Console.WriteLine(name.ToUpper());
            // }

        }
    }
}
