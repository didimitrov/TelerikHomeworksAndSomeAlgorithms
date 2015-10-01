﻿using System;

namespace Strategy
{
    class Program
    {
        private static void Main(string[] args)
        {
            Context context = new Context(new OperationAdd());
            Console.WriteLine("10 + 5 = " + context.ExecuteStrategy(10, 5));


            context = new Context(new OperationSubtract());
            Console.WriteLine("10 - 5 = " + context.ExecuteStrategy(10, 5));

            context = new Context(new OperationMultiply());
            Console.WriteLine("10 * 5 = " + context.ExecuteStrategy(10, 5));
        }
    }
}
