using GenericP13;
using System;
using System.Collections.Generic;
internal class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Find Maximum Number");

        int output = MaximumNumber.MaximumIntNumber(10, 30, 20);
        Console.WriteLine(output);
 
        double output1 = MaximumNumber.MaximumFloatNumber(1.1, 3.0, 2.0);
        Console.WriteLine(output1);

        String output2 = MaximumNumber.MaximumStringNumber("Apple", "peach", "banana");
        Console.WriteLine(output2);

        Console.WriteLine("*****************");

        int[] intArray = { 123, 256, 376, 444, 543, };
        GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
        generic.PrintMaxValue();

        double[] doubleArray = { 1.1, 2.2, 3.3, 4.5, 5.5, };
        GenericMaximum<double> generic1 = new GenericMaximum<double>(doubleArray);
        generic1.PrintMaxValue();

    }
}