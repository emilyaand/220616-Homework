using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220616_classwork
{
    internal class Library
    {
        public string Name { get; set; }
        public List<Books> Books;
        public List<Staff> Staffs;
        public List<Author> Authors;
        public Library(string name)
        {
            Name = name;
            Books = new List<Books>();
            Staffs = new List<Staff>();
            Authors = new List<Author>();
        }
    }
}
