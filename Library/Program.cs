﻿using Library;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        book.DisplayInfo();
    }
}