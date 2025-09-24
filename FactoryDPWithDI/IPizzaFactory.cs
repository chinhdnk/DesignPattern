namespace FactoryDPWithDI;

// ----- Factory Abstraction -----
public interface IPizzaFactory
{
    IPizza CreatePizza(string type);
}

// ----- Concrete Factories -----
public class NYPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new NYStyleCheesePizza();

        throw new ArgumentException("Unknown pizza type");
    }
}

public class ChicagoPizzaFactory : IPizzaFactory
{
    public IPizza CreatePizza(string type)
    {
        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStyleCheesePizza();

        throw new ArgumentException("Unknown pizza type");
    }
}