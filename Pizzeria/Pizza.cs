namespace Pizzeria;

public class Pizza : IBakeable
{
    private List<Ingredient> _ingredients = new List<Ingredient>();

    public void AddIngredient(Ingredient ingredient)
    {
        _ingredients.Add(ingredient);
    }

    public string Describe() =>
    $"This is a pizza with {string.Join(", ", _ingredients)}";

    public string GetInstructions() => "Bake at 250 degrees Celsius for 10 minutes, " +
        "ideally on stone";
}
