// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Singleton Desgin Pattern Example!");

//Below line wont work as Pizza class constructor is private
//Pizza pizza = new Pizza();


//lazy initialization
Console.WriteLine("lazy initialization");
Pizza pizza = Pizza.GetPizzaObject();
//every object as an unique hashcode since we are claiming that we will get single object in singleton pattern we should get both the hashcode similar
Console.WriteLine(pizza.GetHashCode());


Pizza pizza1 = Pizza.GetPizzaObject();
Console.WriteLine(pizza1.GetHashCode());


//eager initialization
Console.WriteLine("eager initialization, eager initialization is thread safe");
Burger burger1 = Burger.GetBurgerObject();
Burger burger2 = Burger.GetBurgerObject();

if (burger1.GetHashCode() == burger2.GetHashCode())
{
    Console.WriteLine("Same Burger object is returned");
}


//thread safety with single locking
Console.WriteLine("thread safety with single locking");
Parallel.Invoke(
    () =>
    {
        Biryani biryani1 = Biryani.getBiryaniObject();
        Console.WriteLine(biryani1.GetHashCode());

    },
    () =>
    {
        Biryani biryani2 = Biryani.getBiryaniObject();
        Console.WriteLine(biryani2.GetHashCode());

    }
    );


//thread safety with double locking
Console.WriteLine("thread safety with double locking");
Parallel.Invoke(
    () =>
    {
        Momo momo1 = Momo.GetMomoObject();
        Console.WriteLine(momo1.GetHashCode());

    },
    () =>
    {
        Momo momo2 = Momo.GetMomoObject();
        Console.WriteLine(momo2.GetHashCode());

    }
    );