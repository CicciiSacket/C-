using System;

namespace WorkWithNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] N = new int[10];
            // int x;

            // do
            // {
            //     Console.WriteLine("Enter the number of number to insert:");
            //     x = Convert.ToInt32(Console.ReadLine());
            // } while (x > 10); //possiamo avere massimo 10 numeri

            // for (var j = 0; j < x; j++)
            // {
            //     Console.WriteLine("Insert the " + (j+1) + "˚ element");
            //     N[j] = Convert.ToInt32(Console.ReadLine());
            // }

            int [] prove = {3,5,2,4,1,7,8,6};
            int max = prove[0];
            int min = prove[0];
            float mean = 0;
            int result = 0;
            foreach (int i in prove)
            {
                if (i > max){
                    max = i;
                }
            }
            Console.WriteLine(max + " È il valore maggiore");
            foreach (int j in prove)
            {
                if (j < min){
                    min = j;
                }
            }
            Console.WriteLine(min + " È il valore minore");
             
            foreach (int x in prove)
            {
                result += x;
            }
            Console.WriteLine(result + " È il valore somma");

            foreach (int y in prove)
            {
                result += y;
                mean = result / prove.Length;
            }
            Console.WriteLine(mean + " È il valore della media");

            
        }
        
    }
}
