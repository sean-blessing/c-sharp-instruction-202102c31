﻿using System;

namespace MethodsApp {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the methods app!");

            int nbr = GetInt("Enter a whole number: ");

            Console.WriteLine("# entered: " + nbr);

            Console.WriteLine("Bye!");
        }

        private static int GetInt(String prompt) {
            int nbr = 0;
            Boolean success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                    success = true;
                }
                catch (Exception e) {
                    Console.WriteLine("Incorrect whole number.  Try again.");
                }
            }
            return nbr;
        }
    }
}
