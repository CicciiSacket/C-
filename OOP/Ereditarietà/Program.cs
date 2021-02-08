using System;

namespace Ereditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            figlia figlia = new figlia();
            Console.WriteLine(figlia.def2());
        }

    }

    class Base 
    {
        public int numero = 10; //public, protected e private come in java;
        void def()
        {
            Console.WriteLine("Sono la classe base");
        }
    }

    class figlia : Base //la classe figlia eredita dalla classe base
    {
        public string def2()
        {
            return "Dalla classe base ho preso " + numero;
        }
    }
}
