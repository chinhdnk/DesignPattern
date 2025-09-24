// See https://aka.ms/new-console-template for more information

using AbstractFactory;

Console.WriteLine("Hello, Welcome to Pizza world!");

PizzaStore  nyStore = new NYPizzaStore();
PizzaStore chicagoStore = new  ChicagoPizzaStore();

Pizza pizza = nyStore.OrderPizza(("cheese"));
Console.WriteLine($"Ethan order a pizza {pizza.Name}");

pizza = chicagoStore.OrderPizza(("cheese"));
Console.WriteLine($"Joel order a pizza {pizza.Name}");


