namespace SingletonPattern;

public class ChocolateBoiler
{
    // Static variable to hold the one instance
    private static ChocolateBoiler instance;

    // Fields representing the state of the boiler
    private bool empty;
    private bool boiled;

    // Private constructor so no one else can instantiate
    private ChocolateBoiler()
    {
        empty = true;
        boiled = false;
    }

    // Public accessor for the single instance
    public static ChocolateBoiler GetInstance()
    {
        if (instance == null)
        {
            instance = new ChocolateBoiler();
        }
        return instance;
    }

    public void Fill()
    {
        if (IsEmpty())
        {
            empty = false;
            boiled = false;
            Console.WriteLine("Filling the boiler with milk and chocolate...");
        }
    }

    public void Boil()
    {
        if (!IsEmpty() && !IsBoiled())
        {
            boiled = true;
            Console.WriteLine("Boiling the mixture...");
        }
    }

    public void Drain()
    {
        if (!IsEmpty() && IsBoiled())
        {
            empty = true;
            Console.WriteLine("Draining the boiled chocolate...");
        }
    }

    public bool IsEmpty()
    {
        return empty;
    }

    public bool IsBoiled()
    {
        return boiled;
    }
}