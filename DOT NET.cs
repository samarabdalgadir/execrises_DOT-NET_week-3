using System;

class Book
{
    // 1. المتغيرات الخاصة
    private string _title;
    private string _author;
    private int _publicationYear;

    // 2. المُنشئ الافتراضي
    public Book()
    {
        _title = "Unknown";
        _author = "Unknown";
        _publicationYear = DateTime.Now.Year;
    }

    // 3. المُنشئ المخصص (Parameterized Constructor)
    public Book(string title, string author, int year)
    {
        _title = title;
        _author = author;
        _publicationYear = year;
    }

    // 4. دالة عرض معلومات الكتاب
    public void DisplayBookInfo()
    {
        Console.WriteLine("Book Info:");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Year: {_publicationYear}");
        Console.WriteLine("----------------------------");
    }
}







class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Book Info Demo ===\n");

        // إنشاء كتاب باستخدام المُنشئ الافتراضي
        Book defaultBook = new Book();
        defaultBook.DisplayBookInfo();

        // إنشاء كتاب باستخدام المُنشئ المخصص
        Book customBook = new Book("The Alchemist", "Paulo Coelho", 1988);
        customBook.DisplayBookInfo();
    }
}
