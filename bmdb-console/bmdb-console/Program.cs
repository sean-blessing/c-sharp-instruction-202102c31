using System;

namespace bmdb_console {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Bootcamp Movie Database!");

            String choice = "y";

            while (choice == "y") {
                int id = MyConsole.getInt("ID:  ");
                String title = MyConsole.getRequiredString("Title:  ");
                String rating = MyConsole.getRequiredString("Rating:  ");
                int year = MyConsole.getInt("Year:  ");
                String director = MyConsole.getRequiredString("Director:  ");

                Movie m = new Movie(id, title, rating, year, director);

                Console.Write("Continue?");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye");
        }
    }
}
