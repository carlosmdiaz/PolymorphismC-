using System.Text.Json;

var person = new Person {
    FirstName="John",
    LastName= "Smith",
    YearOfBirth= 1972
};

var asJson = JsonSerializer.Serialize(person);
System.Console.WriteLine("As JSON:");
System.Console.WriteLine(asJson);

Console.ReadKey();

public class Person {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int YearOfBirth { get; set; }
}