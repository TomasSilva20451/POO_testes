namespace method;

class Program
{
    static void Main(string[] args)
    {
        SayHi("Tomas", "Silva");

        Console.ReadLine();
    }

    static void SayHi(string name, string apelido)
    {
        
        Console.WriteLine("Hello " + name + " " +  apelido);
    }

}

