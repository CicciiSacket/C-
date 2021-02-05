using System;

namespace Swith_GoTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose;
            Console.WriteLine("Scegli");
            Console.WriteLine(" 0 per saluto");
            Console.WriteLine(" 1 per somma");
            choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 0:
                    Console.WriteLine("Hai scelto saluto");
                    goto default; //per spostarsi in un altro caso dello switch, in questo caso il case default
                    break;
                case 1:
                    Console.WriteLine("Hai scelto somma, metti due numeri");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(n1+n2);
                    // goto case 0;
                    break;
                default:
                    Console.WriteLine("ADDIO");
                    break;

            }
        }
    }
}
