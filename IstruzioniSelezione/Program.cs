using System;

namespace IstruzioniSelezione
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 11;
            if (n1 < n2){
                Console.WriteLine("Il primo è più piccolo");
            }
            else if(n1 == n2){
                Console.WriteLine("Sono uguali");
            }
            else{
                Console.WriteLine("Il primo è più grande");
            }
        }
    }
}
