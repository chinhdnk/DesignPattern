// See https://aka.ms/new-console-template for more information

using FactoryDPWithDI;

Console.WriteLine("Hello, Welcome to Pizza world!");

PizzaStore nyStore = new PizzaStore(new NYPizzaFactory());
PizzaStore chicagoStore = new PizzaStore(new ChicagoPizzaFactory());

var pizza1 = nyStore.OrderPizza("cheese");
Console.WriteLine($"Ethan ordered a {pizza1.Name}\n");

var pizza2 = chicagoStore.OrderPizza("cheese");
Console.WriteLine($"Joel ordered a {pizza2.Name}\n");