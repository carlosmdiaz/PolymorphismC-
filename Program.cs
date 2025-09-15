// var pizza = new Pizza();
// pizza.AddIngredient(new Cheddar());
// pizza.AddIngredient(new Mozzarella());
// pizza.AddIngredient(new TomatoSauce());

// System.Console.WriteLine(pizza.Describe());

// System.Console.WriteLine("Variable of type cheddar");
// Cheddar cheddar = new Cheddar();
// System.Console.WriteLine(cheddar.Name);

// System.Console.WriteLine("Variable of type Ingredient");
// Ingredient ingredient = new Cheddar();
// System.Console.WriteLine(ingredient.Name);

var bakeableDishes = new List<object> {
    new Pizza(),
    new Panettone()
};

foreach(var bakeableDish in bakeableDishes)
{
    System.Console.WriteLine(bakeableDish.GetInstructions());
}


Console.ReadKey();

public abstract class Dessert { }

public abstract class Beakable
{
    public abstract string GetInstructions();
}

public class Panettone : Dessert
{

}

public class Pizza
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() =>
    $"This is a pizza with {string.Join(", ", _ingredients)}";

}

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

public abstract class Cheese : Ingredient
{
    public Cheese(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }


}

public class Cheddar : Cheese
{
    public Cheddar(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }
    public override void Prepare() => Console.WriteLine("Grate and sprinkle over pizza.");
}

public class TomatoSauce : Ingredient
{
    public TomatoSauce(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
    public override string Name => "Tomato sauce";
    public bool TomatoesIn100Grams { get; }
    public override void Prepare() => Console.WriteLine("Cook tomatoes with basil, garlic and salt. " + 
        "Spread on pizza.");

}

public class Mozzarella : Cheese
{
    public Mozzarella(int priceIfExtraTopping) : base(priceIfExtraTopping)
    {
    }
    public override string Name => "Mozzarella cheese";
    public bool IsLight { get; }
    public override void Prepare() => Console.WriteLine("Slice thinly and place on top of the pizza.");
}

// Ingredient GenerateRandomIngredient()
// {
//     var random = new Random();
//     var number = random.Next(1, 4);
//     if (number == 1) { return new Cheddar(2, 12); }
//     if (number == 2) { return new TomatoSauce(true); }
//     else { return new Mozzarella(2); }
// }