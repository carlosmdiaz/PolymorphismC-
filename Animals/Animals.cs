namespace Polymorphism.Flyables;

public interface IFlayable
{
     void Fly();
}

public class Bird : IFlayable
{
     public void Tweet() => System.Console.WriteLine("Tweet tweet");
     public void Fly() => System.Console.WriteLine("Flying using its wings.");
}

public class Kite : IFlayable
{
     public void Fly() => System.Console.WriteLine("Flying carried by the wind.");
}

public class Plane : IFlayable
{
     public void Fly() => System.Console.WriteLine("Flying using its engines.");
}