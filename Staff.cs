using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220616_classwork
{
    internal class Staff
    {
        public string Name { get; set; }
        public int Id { get; set; }
        private static int _id;
        public Staff(string name)
        {
            Name = name;
            Id = ++ _id;
        }
    }
}
