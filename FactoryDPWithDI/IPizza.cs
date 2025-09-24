namespace FactoryDPWithDI;

// ----- Abstraction -----
public interface IPizza
{
    string Name { get; }
    void Prepare();
    void Bake();
    void Cut();
    void Box();
}

// ----- Concrete Implementations -----
public class NYStyleCheesePizza : IPizza
{
    public string Name => "NY Style Sauce and Cheese Pizza";
    public void Prepare() => Console.WriteLine("Preparing " + Name);
    public void Bake() => Console.WriteLine("Baking for 25 minutes at 350");
    public void Cut() => Console.WriteLine("Cutting pizza into diagonal slices");
    public void Box() => Console.WriteLine("Placing pizza in official PizzaStore box");
}

public class ChicagoStyleCheesePizza : IPizza
{
    public string Name => "Chicago Style Deep Dish Cheese Pizza";
    public void Prepare() => Console.WriteLine("Preparing " + Name);
    public void Bake() => Console.WriteLine("Baking for 30 minutes at 375");
    public void Cut() => Console.WriteLine("Cutting pizza into square slices");
    public void Box() => Console.WriteLine("Placing pizza in official PizzaStore box");
}