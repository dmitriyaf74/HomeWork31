using Librarian.Classes;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Librarian
{
    internal class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1 - добавить книгу");
            Console.WriteLine("2 - вывести список непрочитанного");
            Console.WriteLine("3 - выйти");
        }

        static string QueryBook()
        {
            Console.WriteLine("Введите название книги:");
            return Console.ReadLine();
        }

        static void FillLibForTest(Library Lb)
        {
            Lb.AddBook("Остров сокровищ");
            Lb.AddBook("Любовь к жизни");
            Lb.AddBook("Приключения Мюнхгаузена");
            Lb.AddBook("Приключения Мюнхгаузена");
            Lb.AddBook("Незнайка в Солнечном городе");
        }

        static void ShowUnReadableBooks(Library Lb)
        {
            foreach (var L in Lb.Data)
            {
                Console.WriteLine($"Книга '{L.Key}' прочитана на {L.Value}%");
            }
        }

        static void Main(string[] args)
        {
            var lb = new Library();
            FillLibForTest(lb);

            while (true)
            {
                ShowMenu();
                var ansver = Console.ReadLine();
                switch (ansver)
                {
                    case "1":
                        lb.AddBook(QueryBook());
                        break;
                    case "2":
                        ShowUnReadableBooks(lb);
                        break;
                    case "3":
                        lb.Stop();
                        return;
                }
            }

        }
    }
}
