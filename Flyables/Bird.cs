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

public interface IFuelable
{
     void Fuel();
}

public class Plane : IFlayable, IFuelable
{
     public void Fly() => System.Console.WriteLine("Flying using its engines.");

     public void Fuel()
     {
          System.Console.WriteLine("Filling tanks with jet fuel.");
     }
}