using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Author
    {
        string author;

        public string InitialsOfTheAuthor { set { author = value; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(author);
        }
    }
}
