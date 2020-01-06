﻿using System;

namespace _04_03_ref_parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 2;

            Console.WriteLine(x);

            // Five(x);
            // Five(out x);
            Double(ref x);

            // this outputs 2 because local variable operation does not affect the global variable operation
            // this shows the difference between value types & reference types
            Console.WriteLine(x);
        }

        // static void Five(int a)
        // out parameter lets us reference the variable that is passed in
        static void Five(out int a)
        {
            a = 5;
            Console.WriteLine(a);
        }

        // function to multiply variable by 2
        // we use ref which does not require you to assign or initialize the parameter
        static void Double(ref int a)
        {
            a = a * 2;
            Console.WriteLine(a);
        }
    }
}
