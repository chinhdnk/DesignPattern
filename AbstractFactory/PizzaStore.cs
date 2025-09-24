namespace AbstractFactory;

// ----- Creator -----
public abstract class PizzaStore
{
    public Pizza OrderPizza(string type)
    {
        Pizza pizza = CreatePizza(type);

        Console.WriteLine($"\n --- Making a {pizza.Name}");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        
        return pizza;
    }
    
    // Factory Method
    protected abstract Pizza CreatePizza(string type);
}
// ----- Concrete Creators -----
public class NYPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new NYStyleCheesePizza();
        else
            return null;
    }
}

public class ChicagoPizzaStore : PizzaStore
{
    protected override Pizza CreatePizza(string type)
    {
        if (type.Equals("cheese", StringComparison.OrdinalIgnoreCase))
            return new ChicagoStyleCheesePizza();
        else
            return null;
    }
}