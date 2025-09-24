namespace AbstractFactory;

// ----- Product -----
public abstract class Pizza
{
    public string Name { get; protected set; }
    public virtual void Prepare()
    {
        Console.WriteLine($"Preparing {Name}");
    }
    public virtual void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }
    public virtual void Bake()
    {
        Console.WriteLine("Baking for 25 minutes at 350");
    }
    public virtual void Box()
    {
        Console.WriteLine("Placing pizza in official PizzaStore box");
    }
}

// ----- Concrete Products -----
public class NYStyleCheesePizza : Pizza
{
    public NYStyleCheesePizza()
    {
        Name = "NY Style Sauce and Cheese Pizza";
    }
} 

public class ChicagoStyleCheesePizza : Pizza
{
    public ChicagoStyleCheesePizza()
    {
        Name = "Chicago Style Deep Dish Cheese Pizza";
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the pizza into square slices");
    }
} 