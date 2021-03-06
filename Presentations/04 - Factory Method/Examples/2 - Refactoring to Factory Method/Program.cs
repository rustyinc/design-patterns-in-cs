﻿using System;

namespace Wincubate.FactoryMethodExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Publication fiction = new Book("Harry Porter goes Beer-binging");
            fiction.Print();

            Console.WriteLine();

            Publication technicalBook = new TechnicalBook("Design Patterns in C#");
            technicalBook.Print();

            Console.WriteLine();

            Publication tabloid = new Tabloid("Krazy W00rld");
            tabloid.Print();
        }
    }
}