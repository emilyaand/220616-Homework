using System;

namespace _220616_classwork
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Library library = new Library();
            Console.WriteLine("1. Kitabxanaya ishci elave et");
            Console.WriteLine("2. Kitabxanaya kitab elave et");
            Console.WriteLine("3. kitabxanadan ishci sil");
            Console.WriteLine("4. Kitabxanadan kitab sil");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.WriteLine ("Kitabxanaya ishci elave et");
                    Console.Write("Adi: ");
                    string adi = Console.ReadLine();
                break;

                case "2":
                    Console.WriteLine("Kitabxanaya kitab elave et");
                    Console.Write("Kitab: ");
                    string kitab = Console.ReadLine();
                break;

                case "3":
                    Console.WriteLine("kitabxanadan ishci sil");
                    Console.Write("Ishcinin adi: ");
                    string ishci = Console.ReadLine();
                break;

                case "4":
                    Console.WriteLine("kitabxanadan kitab sil");
                    Console.Write("Kitabin adi: ");
                    string kitabsil = Console.ReadLine();
                    break;
            }


        }

        class Library
        {
            public string Staff { get; set; }
            public string Books { get; set; }
            public string Author { get; set; }
        }
      
    }
}
