//Programma lezione 9 Udemy course

using System;

namespace MiniProjectClassroom
{
    class Program
    {
        static void Main(string[] args) //writeline va a capo, mentre write no
        {
            int [] debit = new int[10];
            int nStud;
            Console.WriteLine("Welcome");
            Console.Write("Enter the number of student:");
            do
            {
                nStud = System.Convert.ToInt32(Console.ReadLine());
            } while (nStud < 1); //deve esserci almeno uno studente
            
            for (var i = 0; i < nStud; i++)
            {
                do
                {
                    Console.WriteLine("Enter the number of debit del " + (i+1) + "˚ studente"); //se negativo riparte il consolewriteline
                    debit[i] = System.Convert.ToInt32(Console.ReadLine());
                } while (debit[i] < 0);//cicla finchè debit[i] non è < 0
            }

            for (var i = 0; i < nStud; i++)
            {
                if (debit[i] > 3){
                    Console.WriteLine("Il " + (i+1) + "˚ studente è stato bocciato");
                }
                else if(debit[i] > 0){
                    Console.WriteLine("Il " + (i+1) + "˚ studente è stato rimandato con " + debit[i] + " debiti");
                }
                else{
                    Console.WriteLine("Il " + (i+1) + "˚ studente è stato promosso");
                }
            }
        }
    }
}
