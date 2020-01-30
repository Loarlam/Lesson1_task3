using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        public Book (string title, string author, string content)
        {
            this.title.InitialsOfTheTitle = title;
            this.author.InitialsOfTheAuthor = author;
            this.content.InitialsOfTheContent = content;
        }

        public void ShowBookInfo()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
