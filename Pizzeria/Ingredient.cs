namespace Pizzeria;

public abstract class Ingredient
{
    public Ingredient(int priceIfExtraTopping)
    {
        System.Console.WriteLine("Constructor from th Ingredient class");
        PriceIfExtraTopping = priceIfExtraTopping;
    }
    public int PriceIfExtraTopping { get; }
    public virtual string Name { get; } = "Some ingredient";
    public abstract void Prepare();
    public int PublicField;

    public string PublicMethod() => "This method is PUBLIC in the Ingriedient class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingriedient class.";
}