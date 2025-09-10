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

var ingredients = new List<Ingredient>
{
    new Cheddar(),
    new Mozzarella(),
    new TomatoSauce()
};

foreach(var ingredient in ingredients)
{
    System.Console.WriteLine(ingredient.Name);
}

Console.ReadKey();

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

public class Ingredient
{
    public virtual string Name { get; } = "Some ingredient";
    public int PublicField;

    public string PublicMethod() => "This method is PUBLIC in the Ingriedient class.";
    private string PrivateMethod() => "This method is PRIVATE in the Ingriedient class.";
}

public class Cheese : Ingredient
{
    
}

public class Cheddar : Cheese
{
    public override string Name => "Cheddar cheese";
    public int AgedForMonths { get; }

}

public class TomatoSauce : Ingredient
{
    public override string Name => "Tomato sauce";
    public bool TomatoesIn100Grams { get; }
}

public class Mozzarella : Cheese
{
    public override string Name => "Mozzarella cheese";
    public bool IsLight { get; }
}