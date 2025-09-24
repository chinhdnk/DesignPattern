// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Hello Chocolate World!");
ChocolateBoiler boiler = ChocolateBoiler.GetInstance();
boiler.Fill();
boiler.Boil();
boiler.Drain();

// Any other call to GetInstance() returns the same object
ChocolateBoiler boiler2 = ChocolateBoiler.GetInstance();
Console.WriteLine(Object.ReferenceEquals(boiler, boiler2)); // True