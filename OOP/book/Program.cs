using System;

namespace book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book PY = new Book(200,"PY");
            Console.WriteLine(PY.pagine);
        }
    }
}
