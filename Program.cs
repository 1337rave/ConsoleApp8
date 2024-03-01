using System;
using System.Collections.Generic;

class BookList
{
    // Приватне поле для зберігання списку книг
    private List<string> books = new List<string>();

    // Властивість-індексатор для доступу до книг за індексом
    public string this[int index]
    {
        get { return books[index]; }
        set { books[index] = value; }
    }

    // Властивість для отримання загальної кількості книг у списку
    public int Count
    {
        get { return books.Count; }
    }

    // Додавання книги до списку
    public void AddBook(string book)
    {
        books.Add(book);
    }

    // Видалення книги зі списку
    public void RemoveBook(string book)
    {
        books.Remove(book);
    }

    // Перевантажений оператор + для додавання книги до списку
    public static BookList operator +(BookList bookList, string book)
    {
        bookList.AddBook(book);
        return bookList;
    }

    // Перевантажений оператор - для видалення книги зі списку
    public static BookList operator -(BookList bookList, string book)
    {
        bookList.RemoveBook(book);
        return bookList;
    }

    // Перевантажений оператор == для перевірки наявності книги в списку
    public static bool operator ==(BookList bookList, string book)
    {
        return bookList.books.Contains(book);
    }

    // Перевантажений оператор != для перевірки відсутності книги в списку
    public static bool operator !=(BookList bookList, string book)
    {
        return !bookList.books.Contains(book);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BookList myBookList = new BookList();

        // Додавання книг до списку
        myBookList.AddBook("Book 1");
        myBookList += "Book 2"; // Використання перевантаженого оператора +
        myBookList += "Book 3";

        // Видалення книги зі списку
        myBookList.RemoveBook("Book 2");
        myBookList -= "Book 3"; // Використання перевантаженого оператора -

        // Перевірка наявності книг у списку
        Console.WriteLine("Is 'Book 1' in the list? " + (myBookList == "Book 1")); // Використання перевантаженого оператора ==
        Console.WriteLine("Is 'Book 2' in the list? " + (myBookList != "Book 2")); // Використання перевантаженого оператора !=
    }
}
