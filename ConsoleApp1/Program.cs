
Console.WriteLine("Hello, World Polimorfismo!");

public class Animal
{
    public virtual void HacerSonido()
    {
        Console.WriteLine("El animal hace un sonido");
    }
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine("El perro ladra");
    }
}

class Program
{
    static void Main()
    {
        Animal miAnimal = new Animal();
        Animal miPerro = new Perro();

        miAnimal.HacerSonido(); // Salida: El animal hace un sonido
        miPerro.HacerSonido(); // Salida: El perro ladra
    }
}
