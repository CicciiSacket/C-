using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Example test = new Example();
            test.Saluta();

            prova2 prova = new prova2();
            prova.Adios();
        }
    }

    class Example
    {
        public void Saluta(){
            Console.WriteLine("Nuova classe che ha un metodo saluta()");
        }
    }

}