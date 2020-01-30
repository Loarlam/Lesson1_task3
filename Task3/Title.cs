using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Title
    {
        string title;

        public string InitialsOfTheTitle { set { title = value; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title);
        }
    }
}
