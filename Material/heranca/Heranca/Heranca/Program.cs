namespace Heranca;

class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef();
        chef.MakeSpecialDish();

        ItalianChef italianChef = new ItalianChef();
        italianChef.MakeChicken();

        italianChef.MakeSpecialDish();

        Console.ReadLine();

    }
}

