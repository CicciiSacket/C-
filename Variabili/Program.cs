using System;

namespace Variabili
{
        class Program {
        static void Main(string[] args) {
            //tipi di variabili, non tipizza da solo, modi C [+ - / * % -- ++]
            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter = 'D';         // Character
            bool myBool = true;          // Boolean
            string myText = "Hello";     // String, come gli array hanno indicizzazione e possono essere chiamate con stringa[posizione]

            int n1;
            int n2;
            int sum; 

            Console.WriteLine("Insert two number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            sum = n1 + n2; //+ - * /(operatori matematici) 
            Console.Write(sum + "È la somma");    
        }
    }
}
