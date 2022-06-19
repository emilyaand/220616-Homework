using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220616_classwork
{
    internal class Author
    {
        public string Name { get; set; }
        public int İd { get; set; }
        private static int _id;
        public List<Books> books;
        public Author(string name, int id, List<Books> books)
        {
            Name = name;
            İd = id;
            this.books = books;
        }
    }
}
