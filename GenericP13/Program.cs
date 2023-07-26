using GenericP13;
using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Find Maximum Number");

        double output1 = MaxFloatNumber.MaximumFloatNumber(11.2, 22.3, 33.4);
        Console.WriteLine("Max Float Value is: " + output1);
    }
}