namespace FactoryDPWithDI;

// ----- High-level PizzaStore -----
public class PizzaStore
{
    private readonly IPizzaFactory _factory;

    // DIP: depends only on abstraction
    public PizzaStore(IPizzaFactory factory)
    {
        _factory = factory;
    }

    public IPizza OrderPizza(string type)
    {
        IPizza pizza = _factory.CreatePizza(type);

        Console.WriteLine($"\n--- Making a {pizza.Name} ---");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();

        return pizza;
    }
}