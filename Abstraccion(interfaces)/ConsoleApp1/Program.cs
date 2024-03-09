// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
 public abstract class Vehicle
{
    public int MaxSpeed { get; set; }
    public int Acceleration { get; set; }

    public abstract void Move();
}
public class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("El carro se esta miviendo");
    }
}

public class Bike : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("La bisicleta se esta moviendo");
    }
}
