// L' astrazione dei dati è il processo per nascondere alcuni dettagli e mostrare all'utente solo le informazioni essenziali.
// L'astrazione può essere ottenuta con classi astratte o interfacce (di cui imparerai di più nel prossimo capitolo).

// La abstractparola chiave viene utilizzata per classi e metodi:

// Classe astratta: è una classe limitata che non può essere utilizzata per creare oggetti (per accedervi, deve essere ereditata da un'altra classe).

// Metodo astratto: può essere utilizzato solo in una classe astratta e non ha un corpo. Il corpo è fornito dalla classe derivata (ereditata da).
// Una classe astratta può avere metodi sia astratti che regolari:

// Abstract class
abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program
{
  static void Main(string[] args)
  {
    Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method
  }
}


// Un altro modo per ottenere l' astrazione in C # è con le interfacce.
// An interfaceè una " classe astratta " completamente , che può contenere solo metodi e proprietà astratte (con corpi vuoti):

// interface
interface Animal 
{
  void animalSound(); // interface method (does not have a body)
  void run(); // interface method (does not have a body)
}

// Interface
interface IAnimal 
{
  void animalSound(); // interface method (does not have a body)
}

// Pig "implements" the IAnimal interface
class Pig : IAnimal 
{
  public void animalSound() 
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Pig myPig = new Pig();  // Create a Pig object
    myPig.animalSound();
  }
}