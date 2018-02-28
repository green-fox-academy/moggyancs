using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    class Entries
    {
        public string authorName;
        public string title;
        public string text;
        public string date;

        public Entries(string authorName, string title, string text, string publishDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.date = publishDate;
        }
    }
}
