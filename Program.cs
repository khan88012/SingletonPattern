﻿// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Singleton Desgin Pattern Example!");

//Below line wont work as Pizza class constructor is private
//Pizza pizza = new Pizza();

Pizza pizza = Pizza.GetPizzaObject();
//every object as an unique hashcode since we are claiming that we will get single object in singleton pattern we should get both the hashcode similar
Console.WriteLine(pizza.GetHashCode());


Pizza pizza1 = Pizza.GetPizzaObject();
Console.WriteLine(pizza1.GetHashCode());