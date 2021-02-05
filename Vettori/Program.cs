using System;
using System.Linq;

namespace Vettori
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] testVector = new int[10];//ha dieci elementi
            //indicizzazione classica dei vettori, si può inizializzare vuoto omettendo il '10'
            for (var i = 0; i < testVector.Length; i++)
            {
                testVector[i] = 11;
                Console.WriteLine(testVector[i]);//stampa 10 volte 11
            }
            int [] pippo = {1,2,3,4,5};
            for (var j = 0; j < pippo.Length; j++)
            {
                Console.WriteLine(pippo[j]);
            }
            //NEI VETTORI SI PUÒ USARE UN CICLO ALTERNATIVO
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
            foreach (string i in cars) 
            {
                Console.WriteLine(i);
            }
            //UN METODO STD DI ARRAY È IL SORT CLASSICO
            string[] carsS = {"Volvo", "BMW", "Ford", "Mazda"};
            Array.Sort(carsS);
            foreach (string i in carsS)
            {
                Console.WriteLine(i);
            }

            int[] myNumbers = {5, 1, 8, 9};
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(myNumbers.Max());  // metodo returns the largest value -- using System.Linq; necessaria lib
            Console.WriteLine(myNumbers.Min());  // metodo returns the smallest value -- using System.Linq; necessaria lib 
            Console.WriteLine(myNumbers.Sum());  // metodo returns the sum of elements -- using System.Linq; necessaria lib
        }
    }
}
