namespace Polymorphism.Flyables;

public class Bird
{
     public void Tweet() => System.Console.WriteLine("Tweet tweet");
     public void Fly() => System.Console.WriteLine("Flying using its wings.");
}

public class Kite
{
     public void Fly() => System.Console.WriteLine("Flying carried by the wind.");
}

public class Plane
{
     public void Fly() => System.Console.WriteLine("Flying using its engines.");
}