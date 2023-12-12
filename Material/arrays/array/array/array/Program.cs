namespace array;

class Program
{
    static void Main(string[] args)
    {
        int[] luckyNumbers = { 4, 8, 16, 32, 64, 128, 254 };
        string[] friends = new string[5];// array nova com 5 elementos

        friends[0] = "Gin";
        friends[1] = "Kayla";
        friends[2] = "Tommy";
        friends[3] = "Telmo";
        friends[4] = "John";


        luckyNumbers[2] = 900;

        Console.WriteLine(luckyNumbers[2] + " " + friends[2]);

        Console.ReadLine();
    }
}

