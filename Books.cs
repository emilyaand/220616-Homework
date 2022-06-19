using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220616_classwork
{
    internal class Books
    {
        public string Name { get; set; }
        public string BookGenre { get; set; }
        public int Id { get; set; }
        private static int _id;
        public int Page { get; set; }
        public List<Author> author;
        public Books(string name, string bookGenre, int id, int page, List<Author> author)
        {
            Name = name;
            BookGenre = bookGenre;
            Id = id;
            Page = page;
            this.author = author;
        }
    }
}
