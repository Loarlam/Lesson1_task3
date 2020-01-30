using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Content
    {
        string content;

        public string InitialsOfTheContent { set { content = value; } }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
        }
    }
}
