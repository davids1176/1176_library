using System;
namespace SamImplVI
{
    public class Book
    {
        private string _author;
        private string _name;
        private int _year;
        private int _pages;

        public string Author { get { return _author; } }
        public string Name { get { return _name; } }
        public int Year { get { return _year; } }
        public int Pages { get { return _pages; } }

        public Book(string author, string name, int year, int pages)
        {
            _author = author;
            _name = name;
            _year = year;
            _pages = pages;
        }
    }
}