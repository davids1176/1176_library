using System;

namespace SamImplVI
{
    class MainClass
    {
        private static string[] authorNames = { "a", "b", "c" };
        private static string[] bookNames = { "a", "b", "c", "d", "e", "f" };

        public static void Main(string[] args)
        {
            Book[] books = new Book[10];

            Random rand = new Random();

            for (int i = 0; i < books.Length; i++)
            {
                Book book = new Book(authorNames[rand.Next(0, authorNames.Length)], bookNames[rand.Next(0, bookNames.Length)], rand.Next(0, 2024), rand.Next(0, 10000));
                books[i] = book;
            }

            long total = 0;
            foreach (Book book in books)
            {
                total += book.Pages;
            }
            double averagePages = (double)total / books.Length;
            Console.WriteLine($"Průměrný počet stránek: {averagePages}");

            Book maxPagesBook = books[0];
            foreach (Book book in books)
            {
                if (book.Pages > maxPagesBook.Pages)
                {
                    maxPagesBook = book;
                }
            }
            Console.WriteLine($"Jméno knihy s největším počtem stránek: {maxPagesBook.Name}");
        }
    }
}
