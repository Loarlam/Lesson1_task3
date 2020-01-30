﻿
/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Book. Создать классы  Title, Author и Content, каждый из которых должен содержать одно строковое поле и метод void Show().  
Реализуйте возможность добавления в книгу названия книги, имени автора и содержания. 
Выведите на экран разными цветами при помощи метода  Show() название книги, имя автора и содержание. 
*/
using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Эгоистичный ген", "Ричард Докинз", "Если я скажу, что меня больше интересует защита от истребления крупных китов, чем улучшение жизненных условий людей, я рискую шокировать этим некоторых своих друзей.");
            book.ShowBookInfo();
            Console.ReadKey();
        }
    }
}
