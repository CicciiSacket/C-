using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = {1,2,3};
            Console.WriteLine(sum(1,2));
            Console.WriteLine(sumVector(vet));
        }
        static int sum(int a, int b){
            // int a = 1;
            // int b = 2;
            return a+b;
        }

        static int sumVector(int[] array){ //come java void se non ha return
            int result = 0;
            foreach (var item in array)
            {
                result+= item;
               
            }
             return result;
        }
    }
}
