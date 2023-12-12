using System;
using DLL;
using DLL_2__MULTIPLY;
using DLL3;
namespace Testingdll;

class Program
{
    static void Main(string[] args)
    {
        int result = DLL.DLL.Divide(64, 2);
        int result2 = DLL_2__MULTIPLY.DLL2.multiply(5, 5);
        int result3 = DLL3.Class1.sum(4, 6);

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);
        Console.ReadLine();
    }
}

