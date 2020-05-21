using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV3
{
    class NotificationBuilder : IBuilder
    {
        private String author;
        private String title;
        private String text;
        private DateTime timestamp;
        private Category level;
        private ConsoleColor color;

        public NotificationBuilder()
        {
            author = "Domagoj";
            title = "Naslov";
            text = "Tekst";
            timestamp = DateTime.Now;
            level = Category.INFO;
            color = ConsoleColor.White;
        }
        public ConsoleNotification Build()
        {
            return new ConsoleNotification(author, title, text, timestamp, level, color);
        }
        public IBuilder SetAuthor(String author)
        {
            this.author = author;
            return this;
        }
        public IBuilder SetTitle(String title)
        {
            this.title = title;
            return this;
        }
        public IBuilder SetTime(DateTime time)
        {
            this.timestamp = time;
            return this;
        }
        public IBuilder SetLevel(Category level)
        {
            this.level = level;
            return this;
        }
        public IBuilder SetColor(ConsoleColor color)
        {
            this.color = color;
            return this;
        }
        public IBuilder SetText(String text)
        {
            this.text = text;
            return this;
        }
    }
}
