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

//TRY CATCH 
// L' tryistruzione consente di definire un blocco di codice da testare per gli errori durante l'esecuzione.
// L' catchistruzione consente di definire un blocco di codice da eseguire, se si verifica un errore nel blocco try.
// Le parole chiave trye catchsono disponibili in coppia:
try
{
  int[] myNumbers = {1, 2, 3};
  Console.WriteLine(myNumbers[10]);
}
catch (Exception e)
{
  Console.WriteLine("Something went wrong.");
}