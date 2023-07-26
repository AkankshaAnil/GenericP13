using GenericP13;
using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Find Maximum Number");

        string output2 = MaxStringNumber.MaximumStringNumber("Apple", "peach", "Banana");
        Console.WriteLine("Max String Value is: " + output2);
    }
}